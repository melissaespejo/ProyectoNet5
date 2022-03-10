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
        public ActionResult GetAll(){
            try{
                return Ok(_userBusinessService.GetAllUsers());
            } 
            catch(Exception ex){
                return BadRequest(ex.Message);
            }
            //return _context.Users.ToList();
        }

        [HttpPost("[action]")]
        public ActionResult Create([FromBody] User user){  
            try{
                return Ok(_userBusinessService.CreateUser(user));
            }
            catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("[action]")]
        public ActionResult Update(User user){
            try{
                return Ok(_userBusinessService.UpdateUser(user));
            }
            catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("[action]")]
        public ActionResult DeletebyId(int id){
            try{
                return Ok(_userBusinessService.DeletebyIdUser(id));
            }
            catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }
    }
}