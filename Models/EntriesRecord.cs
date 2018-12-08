using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSecurity.Models
{
    public class EntriesRecord : IModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Event { get; set; }
        public DateTime Time { get; set; }
    }
}
