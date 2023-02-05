using JWT.Application.Data;
using JWT.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT.Application.Services
{
    public interface IAuthenticationService
    {  /// <summary>
       /// Generates the user JWT.
       /// </summary>
       /// <param name="loginDto">The login dto.</param>
       /// <returns>Task&lt;Response&lt;System.String&gt;&gt;.</returns>
        object Login(LoginDto loginDto); 
    }
}
