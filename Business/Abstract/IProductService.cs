using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResults<Product>  GetById(int productId);
        IDataResults<List<Product>> GetList();
        IDataResults<List<Product>> GetListByCategory(int categoryId);
        IResults Add(Product product); // void tip döndürdüğümüz için data değil result dönecek sadece
        IResults Update(Product product);
        IResults Delete(Product product);

    }
}
