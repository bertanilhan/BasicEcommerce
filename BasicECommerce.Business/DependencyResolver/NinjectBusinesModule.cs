using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicECommerce.Business.Abstract;
using BasicECommerce.Business.Concrete;
using BasicECommerce.DataAccess.Abstract;
using BasicECommerce.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace BasicECommerce.Business.DependencyResolver
{
    public class NinjectBusinesModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>();
            Bind<IProductDal>().To<EfProductDal>();

            Bind<ICategoryService>().To<CategoryManager>();
            Bind<ICategoryDal>().To<EfCategoryDal>();
        }
    }
}
