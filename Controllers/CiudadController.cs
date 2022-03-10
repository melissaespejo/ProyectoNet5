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
        public IEnumerable<Ciudad> GetAll()
        {
            return _ciudadBusinessService.GetAllCiudad();
        }
        [HttpPost("[action]")]
        public Ciudad Create(Ciudad ciudad){
            return _ciudadBusinessService.CreateCiudad(ciudad);
        }
    }
}