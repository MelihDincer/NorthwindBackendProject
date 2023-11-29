using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    //Bütün projelerde veritabanı kullanacağımız için, bu projeye bağlı olmayan Core projesinin içerisinde IEntity interface eklenmiştir.
    public interface IEntity //Burada; Entities katmanında tanımlanan sınıfların bir entity sınıfı olduğunu ve bir kaynağının olduğunu(database) belirtmek için IEntity interface oluşturduk. Sadece bunu belirtmek için oluşturduk farklı bir şeyi yok. Db ile çalışan sınıflar bu sınıftan miras alacak.
    {
    }
}
