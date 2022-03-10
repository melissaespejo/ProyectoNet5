using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.DataService.Interfaces
{
    public interface IPersonaDataService
    {
        public List<Persona> GetAllPersonas();
        public Persona CreatePersona(Persona persona);
    }
}