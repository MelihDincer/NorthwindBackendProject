using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        void Add(User user);

        //Parametre olarak verilen kullanıcının rollerini çekmek için imza
        List<OperationClaim> GetClaims(User user);
    }
}
