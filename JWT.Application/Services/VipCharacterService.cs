using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using JWT.Application.Enum;
using Microsoft.AspNetCore.Http;
namespace JWT.Application.Services
{
    public class VipCharacterService : IVipCharacterService
    { 
        public Task<string> GetModificationPage()
        {
                return Task.FromResult("Vip modification page");
        }
    }
}
