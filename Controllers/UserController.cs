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
    public class UserController: ControllerBase
    {
        //private UserContext _context;
        private IUserBusinessService _userBusinessService;
        public UserController(IUserBusinessService userBusinessService)
        {
            //_context=context;
            _userBusinessService = userBusinessService;
        }

        [HttpGet("[action]")]
        public IEnumerable<User> GetAll()
        {
            return _userBusinessService.GetAllUsers();
            //return _context.Users.ToList();
        }

        [HttpPost("[action]")]
        public User Create(User user){
            
            return _userBusinessService.CreateUser(user);
        }
        [HttpPut("[action]")]
        public User Update(User user){
            return _userBusinessService.UpdateUser(user);
        }
        [HttpDelete("[action]")]
        public int DeletebyId(int id){
            return _userBusinessService.DeletebyIdUser(id);
        }
        
    }
}