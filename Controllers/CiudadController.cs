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
    public class CiudadController : ControllerBase
    {
        private ICiudadBusinessService _ciudadBusinessService;
        public CiudadController(ICiudadBusinessService ciudadBusinessService){
            _ciudadBusinessService = ciudadBusinessService;
        }
        [HttpGet("[action]")]
        public ActionResult GetAll()
        {
            try{
                return Ok(_ciudadBusinessService.GetAllCiudad());
            }
            catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("[action]")]
        public ActionResult Create([FromBody] Ciudad ciudad){
            try{
                return Ok(_ciudadBusinessService.CreateCiudad(ciudad));
            }
            catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }
    }
}