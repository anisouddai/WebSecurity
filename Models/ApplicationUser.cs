﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace WebSecurity.Models
{
    // Ajoute des deonnées pour l'application utilisateur en mettant à jour les propriétés de la classe ApplicationUser
    public class ApplicationUser : IdentityUser
    {
        // Constructeur
        public ApplicationUser()
            : base()
        {
        }
   
        // Constructeur paramètré
        public ApplicationUser(string userName, string firstName, string lastName, DateTime birthDay)
            : base(userName)
        {
            base.Email = userName;
 
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDay = birthDay;
        }
        
        [JsonProperty("first")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
 
        [JsonProperty("last")]
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        
        [JsonProperty("gender")]
        [StringLength(50)]
        public string Gender { get; set; }
 
        [JsonProperty("dob")]
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
        
        [JsonProperty("registered")]
        [DataType(DataType.Date)]
        public DateTime Registered { get; set; }
        
        public string Role { set; get; }
        
        [JsonProperty("cell")]
        public string Cell { set; get; }
        
        [JsonProperty("street")]
        public string Street { set; get; }
        
        [JsonProperty("city")]
        public string City { set; get; }
        
        [JsonProperty("state")]
        public string State { set; get; }
        
        [JsonProperty("postcode")]
        public string PostalCode { set; get; }
 
        public string FullName => $"{this.FirstName} {this.LastName}";
    }
}
