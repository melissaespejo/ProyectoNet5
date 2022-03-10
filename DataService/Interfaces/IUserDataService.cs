using System.Collections.Generic;
using TodoApi.Models;
using System.Linq;

namespace TodoApi.DataService.Interfaces
{
    public interface IUserDataService
    {
        public List<User> GetAllUsers(); 
        //create
        public User CreateUser(User user);
        //update
        public User UpdateUser(User user);
        //delete 
        public int DeletebyIdUser(int id);
    }
}