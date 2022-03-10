using System.Collections.Generic;
using TodoApi.BusinessService.Interfaces;
using TodoApi.DataService.Interfaces;
using TodoApi.Models;

namespace TodoApi.BusinessService
{
    public class UserBusinessService : IUserBusinessService
    {
        private IUserDataService _userDataService;
        public UserBusinessService(IUserDataService userDataService){
            _userDataService = userDataService;
        }
        public List<User> GetAllUsers()
        {
            var userList = _userDataService.GetAllUsers();
            //logica
            //eliminar la contraseña
            //ordenar
            return userList;
        }
        //create
        public User CreateUser(User user){
            var userCreate = _userDataService.CreateUser(user);
            return userCreate;
        }
        //update
        public User UpdateUser(User user){
            var userUpdate = _userDataService.UpdateUser(user);
            return userUpdate;
        }
        //delete
        public int DeletebyIdUser(int id){
            var userDelete = _userDataService.DeletebyIdUser(id);
            return userDelete;
        }
        

        
    }
}