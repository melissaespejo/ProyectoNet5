using System.Collections.Generic;
using TodoApi.BusinessService.Interfaces;
using TodoApi.DataService.Interfaces;
using TodoApi.Models;

namespace TodoApi.BusinessService
{
    public class CiudadBusinessService : ICiudadBusinessService
    {
        private ICiudadDataService _ciudadDataService;
        public CiudadBusinessService (ICiudadDataService ciudadDataService){
            _ciudadDataService = ciudadDataService;
        }
        public List<Ciudad> GetAllCiudad(){
            var ciudadList =  _ciudadDataService.GetAllCiudad();
            return ciudadList;
        }
        public Ciudad CreateCiudad(Ciudad ciudad){
            var ciudadCreate = _ciudadDataService.CreateCiudad(ciudad);
            return ciudadCreate;
        }
    }
}