using JWT.Application.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT.Application.Services
{
    public interface IVipCharacterService
    {
        Task<string> GetModificationPage();
    }
}
