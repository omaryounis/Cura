using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT.Application.Enum
{
    public enum StatusCode
    {
        NotAuthenticated = 401,
        NotAuthorized = 403,
        NotFound = 404,
        Ok=200
    }
}
