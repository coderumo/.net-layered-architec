using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Jwt;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResults<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResults<User> Login(UserForLoginDto userForLoginDto);
        IResults UserExists(string email);
        IDataResults<AccessToken> CreateAccesToken(User user);
    }
}
