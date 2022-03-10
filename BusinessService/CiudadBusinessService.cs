using System.Collections.Generic;
using TodoApi.BusinessService.Interfaces;
using TodoApi.DataService.Interfaces;
using TodoApi.Models;

namespace TodoApi.BusinessService
{
    public class CiudadBusinessService : ICiudadBusinessService
    {
        private ICiudadBusinessService _ciudadBusinessService;
        public CiudadBusinessService (ICiudadBusinessService ciudadBusinessService){
            _ciudadBusinessService = ciudadBusinessService;
        }
        public List<Ciudad> GetAllCiudad(){
            var ciudadList =  _ciudadBusinessService.GetAllCiudad();
            return ciudadList;
        }
        public Ciudad CreateCiudad(Ciudad ciudad){
            var ciudadCreate = _ciudadBusinessService.CreateCiudad(ciudad);
            return ciudadCreate;
        }
    }
}