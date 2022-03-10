using System.Collections.Generic;
using TodoApi.BusinessService.Interfaces;
using TodoApi.DataService.Interfaces;
using TodoApi.Models;

namespace TodoApi.BusinessService
{
    public class PersonaBusinessService : IPersonaBusinessService
    {
        private IPersonaDataService _personaDataService;
        public PersonaBusinessService (IPersonaDataService personaDataService){
            _personaDataService = personaDataService;
        }
        public List<Persona> GetAllPersonas()
        {
            var personaList = _personaDataService.GetAllPersonas();
            return personaList;
        }
        public Persona CreatePersona(Persona persona){
            var personaCreate = _personaDataService.CreatePersona(persona);
            return personaCreate;
        }

    }
}