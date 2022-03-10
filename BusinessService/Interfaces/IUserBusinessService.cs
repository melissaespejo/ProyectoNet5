using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.BusinessService.Interfaces
{
    public interface IUserBusinessService
    {
        List<User> GetAllUsers();
         //create
        User CreateUser(User user);
        //update
        User UpdateUser(User user);
        //delete
        int DeletebyIdUser(int id);  
        
    }
}