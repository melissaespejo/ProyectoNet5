using System.Collections.Generic;
using TodoApi.Models;
using System.Linq;
using TodoApi.DataService.Interfaces;

namespace TodoApi.DataService
{
    public class UserDataService : IUserDataService
    {
        private GeneralContext _context;

        public UserDataService(GeneralContext context){
            _context = context;
        }
        /*      USER        */
        public List<User> GetAllUsers(){
            return _context.Users.ToList();
        }

        //create
        public User CreateUser(User user){
            _context.Users.Add(user);
            _context.SaveChanges();
            return _context.Users.FirstOrDefault(e=>e.UserId==user.UserId);
        }

        //update
        public User UpdateUser(User user){
            if(user!=null){
                _context.Users.Update(user);
                _context.SaveChanges();
            }
            return _context.Users.FirstOrDefault(e=>e.UserId == user.UserId);
        }

        //delete 
        public int DeletebyIdUser(int id){
            User user = _context.Users.FirstOrDefault(e=>e.UserId==id);
            if(user!=null){
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
            return id;
        }
        
        

    }
}