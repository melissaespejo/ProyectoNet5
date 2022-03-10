using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.BusinessService.Interfaces
{
    public interface ICiudadBusinessService
    {
        List<Ciudad> GetAllCiudad();
        Ciudad CreateCiudad(Ciudad ciudad);
    }
}