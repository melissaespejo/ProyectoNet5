using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.BusinessService.Interfaces
{
    public interface IPersonaBusinessService
    {
        List<Persona> GetAllPersonas();
        Persona CreatePersona(Persona persona);
    }
}