using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    public class User
    {
        [Key]
        public long UserId {get; set;}
        public string userName {get; set;}
        public string password {get; set;}
        public Persona Persona {get; set;}
    }
    
}