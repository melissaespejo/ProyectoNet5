using System.Collections.Generic;

namespace TodoApi.Models
{
    public class Ciudad
    {
        public long CiudadId {get; set;}
        public string Name {get; set;}
        
        public ICollection<Persona> Persona {get; set;}
    }
}