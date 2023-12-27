using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        //Kullanıcının rollerini listeleme
        List<OperationClaim> GetClaims(User user);
        //Yeni kullanıcı oluşturma
        void Add(User user);
        //Kullanıcıyı mail bilgisi ile bulma
        User GetByMail(string mail);
    }
}
