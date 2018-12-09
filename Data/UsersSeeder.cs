using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using WebSecurity.Models;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebSecurity.Helpers;

namespace WebSecurity.Data
{
    public class UsersSeeder
    {
       
        private static readonly String _randomUserAPI_URL = "https://randomuser.me/api/";
        
        public static async Task Initialize(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager, ILogger<DbInitializer> logger)
        {
            // si il y a déjà un rôle on s'arrête
            if (!context.Users.Any())
            {
                for (int i = 0; i < new Random().Next(15,20); i++)
                {
                    await CreatetMockUser(userManager, logger);
                }
            }
            return; 
        }
        
        public static async Task CreatetMockUser(UserManager<ApplicationUser> userManager, ILogger<DbInitializer> logger)
        {
            // Ouvre un client Http
            HttpClient client = new HttpClient();

            // Fait une requête Http et récupère la réponse
            HttpResponseMessage response = await client.GetAsync(new Uri(_randomUserAPI_URL));

            // Récupére la réponse de JSON
            var jsonString = await response.Content.ReadAsStringAsync();

            // Deserialize JSON
            var json = JsonConvert.DeserializeObject(jsonString);
            
            
            // Analyse la réponse JSON 
            JObject parsedJson = JObject.Parse(jsonString);
            
            ApplicationUser mockUser = null;
            IList<JToken> results = parsedJson["results"].Children().ToList();
            
            // Construit les objets
            foreach (JToken result in results)
            {
                IList<JToken> location = result["location"].Children().ToList();
                IList<JToken> name = result["name"].Children().ToList();
                IList<JToken> login = result["login"].Children().ToList();

                mockUser = new ApplicationUser
                {
                    Gender = result["gender"].ToString(),
                    Email = result["email"].ToString(),
                    Registered = DateTime.Now,
                    Cell = result["cell"].ToString(),
                    PhoneNumber = result["phone"].ToString(),
                    Street = location[0].First.ToString(),
                    City = location[1].First.ToString(),
                    State = location[2].First.ToString(),
                    PostalCode = location[3].First.ToString(),
                    FirstName = name[1].First.ToString(),
                    LastName = name[2].First.ToString(),
                    Role = new Random().Next(0,10)%2==0?RolesConstants.BUSINESSCUSTOMER : RolesConstants.RESIDENTIALCUSTOMER,
                    UserName = ASCIIEncoding(result["email"].ToString())
                };
                
                // On crée un utilisateur et on regarde si cela à échoué ou pas
                //Si c'est un succès on ajoute un role à l'utilisateur
                // On consigne l'erreur en cas d'échec
                var identityResult = await userManager.CreateAsync(mockUser, login[1].First.ToString());
                
                if (identityResult.Succeeded)
                {
                   
                    var roleResult = await userManager.AddToRoleAsync(mockUser,mockUser.Role);
                    logger.LogDebug($"Created the user `{mockUser.FullName}` successfully");
                }
                else
                {
                    var exception = new ApplicationException($"Mock user `{mockUser.FirstName}` cannot be created");
                    logger.LogError(exception, GetIdentiryErrorsInCommaSeperatedList(identityResult));
                   
                }
                logger.LogInformation($"Create the user `{mockUser.FullName}` for application");
      
            }
        }
       
        private static string GetIdentiryErrorsInCommaSeperatedList(IdentityResult identityResult)
        {
            string errors = null;
            foreach (var identityError in identityResult.Errors)
            {
                errors += identityError.Description;
                errors += ", ";
            }
            return errors;
        }
        
        public static string RemoveDiacritics(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            text = text.Normalize(NormalizationForm.FormD);
            var chars = text.Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToArray();
            return new string(chars).Normalize(NormalizationForm.FormC);
        }

        public static string ASCIIEncoding(string text)
        {
            Encoding asciiEncoding = Encoding.ASCII;
            // Tableau contenant les bytes encodés
            byte[] bytes;
            // Tableau pour construire les caractère décodé
            char[] chars = new char[50];
            // Crée un index pour le caractère actuel 
            int index = 0;  
            
            bytes = asciiEncoding.GetBytes(text);
            
            // Decode les bytes pour un tableau de caractère
            int count = asciiEncoding.GetCharCount(bytes);
            if (count + index >=  chars.Length)
                Array.Resize(ref chars, chars.Length + 50);
            
            int written = asciiEncoding.GetChars(bytes, 0, 
                bytes.Length, 
                chars, index);              
            index = index + written;
           
            string decodedString = new string(chars, 0, index - 1);
            return RemoveDiacritics(decodedString);
        }
    }

}