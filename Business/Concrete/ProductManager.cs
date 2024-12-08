using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;


namespace Business.Concrete
{
    // daha sonra iş kurallarını yaz
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IDataResults<Product> GetById(int productId)
        {
            return new SuccessDataResults<Product>(_productDal.Get(filter: p => p.ProductID == productId));
        }

        public IDataResults<List<Product>> GetList()
        {
            return new SuccessDataResults<List<Product>>(_productDal.GetList().ToList());
        }

        public IDataResults<List<Product>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResults<List<Product>>(_productDal.GetList(filter: p => p.CategoryId == categoryId).ToList());
        }


        public IResults Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResults Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);

        }


        public IResults Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }

}
