using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        //Data döneceğimiz için önceden oluşturduğumuz IDataResult'u döndürdük.
        IDataResult<Product> GetById(int productId);
        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetListByCategory(int categoryId);

        //Burada ise result dönüleceğinden dolayı önceden oluşturduğumuz IResult'u döndürdük.
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);
    }
}
