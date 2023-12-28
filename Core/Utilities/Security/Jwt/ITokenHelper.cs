using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        //Kullanıcı bilgisi ve rol bilgisinden Token oluşturma işlemi
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
