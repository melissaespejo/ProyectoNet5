using TodoApi.Models;

namespace TodoApi.BusinessService.Interfaces
{
    public interface IJWTManagerRepository
    {
         public string GetToken(User user);
    }
}