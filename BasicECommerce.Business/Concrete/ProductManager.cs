using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicECommerce.Business.Abstract;
using BasicECommerce.DataAccess.Abstract;
using BasicECommerce.Entities.Concrete;

namespace BasicECommerce.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategoryId(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId);
        }

        public void Add(Product product)
        {
             _productDal.Add(product);
        }

        public void Update(Product product)
        {
            _productDal.Add(product);
        }

        public void DeleteById(int id)
        {
            _productDal.Delete(new Product{ProductId = id});
        }
    }
}
