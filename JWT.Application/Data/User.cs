using JWT.Application.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT.Application.Data
{
    public class User
    {
        public string UserName { get; set; }
        public UserRole Role { get; set; }
    }
}
