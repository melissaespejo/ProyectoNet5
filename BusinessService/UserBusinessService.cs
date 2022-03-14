using System.Collections.Generic;
using TodoApi.BusinessService.Interfaces;
using TodoApi.DataService.Interfaces;
//
using TodoApi.Models;

using TodoApi.ViewModels;
using AutoMapper;

namespace TodoApi.BusinessService
{
    public class UserBusinessService : IUserBusinessService
    {
        private IUserDataService _userDataService;
        private IMapper _mapper;
        public UserBusinessService(IUserDataService userDataService, IMapper mapper){
            _userDataService = userDataService;
            _mapper = mapper;
        }
        public List<UserViewModel> GetAllUsers()
        {
            var userList = _userDataService.GetAllUsers();
            var UserViewModelList = _mapper.Map<List<UserViewModel>>(userList);
            //logica
            //eliminar la contraseña
            //ordenar
            return UserViewModelList;
        } 
        //create
        /*public User CreateUser(User user){
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
        public string Login(string user, string password){
            //verificar que usuario y contraseña verifica con la bd
            return "holi";
            //llamar servicio jwtservivr para genersr el token

            //error throw exception("Usuario no encontrado")
        }
        */
        
    }
}