using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Jwt;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //Sisteme login ya da register olma durumlarında yapılacak bazı işlemler
    public interface IAuthService
    {
        //Register işlemi
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        //Login işlemi
        IDataResult<User> Login(UserForLoginDto userForLoginDto);

        //Kullanıcı var mı diye kontrol işlemi
        IResult UserExists(string email);

        //AccessToken üretme işlemi
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
