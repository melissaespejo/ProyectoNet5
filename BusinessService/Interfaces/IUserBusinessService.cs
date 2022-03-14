using System.Collections.Generic;
using TodoApi.Models;
using TodoApi.ViewModels;

namespace TodoApi.BusinessService.Interfaces
{
    public interface IUserBusinessService
    {
        List<UserViewModel> GetAllUsers();
         //create
        /*UserVie CreateUser(User user);
        //update
        UserViewModel UpdateUser(User user);
        //delete
        int DeletebyIdUser(int id);  
        */
    }
}