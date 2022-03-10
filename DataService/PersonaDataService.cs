using System.Collections.Generic;
using TodoApi.Models;
using System.Linq;
using TodoApi.DataService.Interfaces;

namespace TodoApi.DataService
{
    public class PersonaDataService : IPersonaDataService
    {
        private GeneralContext _context;
        public PersonaDataService(GeneralContext context){
            _context = context;
        }
        public List<Persona> GetAllPersonas(){
            return _context.Persona.ToList();
        }
        public Persona CreatePersona(Persona persona){
            _context.Persona.Add(persona);
            _context.SaveChanges();
            return _context.Persona.FirstOrDefault(e => e.Id==persona.Id);
        }
    }
}