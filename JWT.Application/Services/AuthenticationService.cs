using JWT.Application.Data;
using JWT.Application.Dtos;
using JWT.Application.Enum;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWT.Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private IConfiguration _config;
        public AuthenticationService(IConfiguration config)
        {
            _config = config;
        }

        public object Login(LoginDto loginDto)
        {
            var user = AuthenticateUser(loginDto);
            if(user == default)
                return "invalid username or password";
            else
                return new { token = GenerateJSONWebToken(user) };
        }

        private User? AuthenticateUser(LoginDto loginDto)
        {
            User? user = default;
            if (loginDto.UserName == "admin" && loginDto.Password=="123")
                user = new User { UserName = "Admin", Role = UserRole.Administration };
            if (loginDto.UserName == "omar" && loginDto.Password == "123")
                user = new User { UserName = "omar", Role = UserRole.NormalPlayer };
            if (loginDto.UserName == "islam" && loginDto.Password == "123")
                user = new User { UserName = "islam", Role = UserRole.VIPPlayer };
            return user;
        }
        private string GenerateJSONWebToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Name,user.UserName),
                new Claim("Role",user.Role.ToString())
            };

                var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                    _config["Jwt:Issuer"],
                    claims,
                    expires: DateTime.Now.AddMinutes(120),
                    signingCredentials: credentials);

                return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
