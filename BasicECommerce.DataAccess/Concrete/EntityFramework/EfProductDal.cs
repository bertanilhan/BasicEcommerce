using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicECommerce.Core.DataAccess.EntityFramework;
using BasicECommerce.DataAccess.Abstract;
using BasicECommerce.Entities.Concrete;

namespace BasicECommerce.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
    }
}
