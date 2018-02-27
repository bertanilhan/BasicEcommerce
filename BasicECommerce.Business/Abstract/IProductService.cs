using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicECommerce.Entities.Concrete;

namespace BasicECommerce.Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        List<Product> GetAll();
        List<Product> GetByCategoryId(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void DeleteById(int id);
    }
}
