namespace TodoApi.Models
{
    public class Persona
    {
        
        public long Id {get; set;}
        public long Dni {get; set;}
        public string Name {get; set;}
        
        public long UserFK {get; set;}
        public User user {get; set;}

        
        public long CiudadFK {get; set;}
        public Ciudad Ciudad {get; set;}

    }
}