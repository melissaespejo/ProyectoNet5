using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.DataService.Interfaces
{
    public interface ICiudadDataService
    {
         public List<Ciudad> GetAllCiudad();
         public Ciudad CreateCiudad(Ciudad ciudad);
    }
}