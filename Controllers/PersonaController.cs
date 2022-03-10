using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TodoApi.BusinessService.Interfaces;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonaController : ControllerBase
    {
        private IPersonaBusinessService _personaBusinessService;
        public PersonaController(IPersonaBusinessService personaBusinessService){
            _personaBusinessService = personaBusinessService;
        }

        [HttpGet("[action]")]
        public IEnumerable<Persona> GetAll()
        {
            return _personaBusinessService.GetAllPersonas();
        }
        [HttpPost("[action]")]
        public Persona Create(Persona persona){
            return _personaBusinessService.CreatePersona(persona);
        }
    }
}
    