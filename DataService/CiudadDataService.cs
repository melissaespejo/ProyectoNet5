using System.Collections.Generic;
using TodoApi.Models;
using System.Linq;
using TodoApi.DataService.Interfaces;

namespace TodoApi.DataService
{
    public class CiudadDataService : ICiudadDataService
    {
        private GeneralContext _context;
        public CiudadDataService(GeneralContext context){
            _context = context;
        }
        public List<Ciudad> GetAllCiudad(){
            return _context.Ciudad.ToList();
        }
        public Ciudad CreateCiudad(Ciudad ciudad){
            _context.Ciudad.Add(ciudad);
            _context.SaveChanges();
            return _context.Ciudad.FirstOrDefault(e => e.CiudadId==ciudad.CiudadId);
        }

        
    }
}