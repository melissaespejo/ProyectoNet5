using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using TodoApi.BusinessService.Interfaces;
using TodoApi.Models;

namespace TodoApi.BusinessService
{
    public class JWTManagerRepository : IJWTManagerRepository
    {
        private readonly IConfiguration iconfiguration;
        public JWTManagerRepository(IConfiguration configuration){
            iconfiguration = configuration;
        }
        public string GetToken(User user){
            if(user.userName != "admin"){
                throw new System.Exception("Usuario no encontrado");
            }
            // Else we generate JSON Web Token
		    var tokenHandler = new JwtSecurityTokenHandler();
		    var tokenKey = Encoding.UTF8.GetBytes(iconfiguration["JWT:Key"]);
		    var tokenDescriptor = new SecurityTokenDescriptor
		    {
                Subject = new ClaimsIdentity(new Claim[]{
                    new Claim(ClaimTypes.Name, user.userName)                    
                    }),
                Expires = DateTime.UtcNow.AddMinutes(10),
		        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),SecurityAlgorithms.HmacSha256Signature)
		    };
		    var token = tokenHandler.CreateToken(tokenDescriptor);
		    return tokenHandler.WriteToken(token);
        }
    }
}