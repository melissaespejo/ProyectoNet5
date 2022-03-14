using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TodoApi.BusinessService.Interfaces;
using TodoApi.Models;
using TodoApi.ViewModels;

namespace TodoApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UserController: ControllerBase
    {
        //private UserContext _context;
        private IUserBusinessService _userBusinessService;
        private IJWTManagerRepository _JWTManagerRepository;
        public UserController(IUserBusinessService userBusinessService, IJWTManagerRepository managerRepository)
        {
            //_context=context;
            _userBusinessService = userBusinessService;
            _JWTManagerRepository = managerRepository;
        }
        [AllowAnonymous]
        [HttpPost("[action]")]
        public ActionResult Login(User user){
            try{
                return Ok(_JWTManagerRepository.GetToken(user));
            }
            catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }
        [AllowAnonymous]
        [HttpGet("[action]")]
        public IEnumerable<UserViewModel> GetAllWithAuthorize(){
            try{
                return _userBusinessService.GetAllUsers();
            } 
            catch(Exception ex){
                return (IEnumerable<UserViewModel>)BadRequest(ex.Message);
            }
            //return _context.Users.ToList();
        }
        [AllowAnonymous]
        [HttpGet("[action]")]
        public IEnumerable<UserViewModel> GetAll(){
            try{
                return (IEnumerable<UserViewModel>)Ok(_userBusinessService.GetAllUsers());
            } 
            catch(Exception ex){
                return (IEnumerable<UserViewModel>)BadRequest(ex.Message);
            }
            //return _context.Users.ToList();
        }

        /*[HttpPost("[action]")]
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
        }*/
    }
}