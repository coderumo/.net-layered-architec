using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.Jwt;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper) 
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResults<AccessToken> CreateAccesToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResults<AccessToken>(accessToken, Messages.AccessTokenCreated);
            
            
        }

        public IDataResults<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck==null)
            {
                return new ErrorDataResults<User>(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password,userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResults<User>(Messages.PasswordError);

            }

            return new SuccessDataResults<User>(userToCheck, Messages.SuccesfullLogin);
        }

        public IDataResults<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userService.Add(user);
            return new SuccessDataResults<User>(user, Messages.SuccesfullRegistered);

        }

        public IResults UserExists(string email)//kullanıcı sistemde var mı
        {
            if (_userService.GetByMail(email) != null)
            {
                return new ErrorResults(Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
