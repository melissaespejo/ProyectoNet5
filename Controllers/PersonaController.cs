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
        public ActionResult GetAll()
        {
           try{
               return Ok(_personaBusinessService.GetAllPersonas());
           }
           catch(Exception ex){
               return BadRequest(ex.Message);
           }
        }
        [HttpPost("[action]")]
        public ActionResult Create([FromBody] Persona persona){
            try{
                return Ok(_personaBusinessService.CreatePersona(persona));
            }
            catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }
    }
}
    