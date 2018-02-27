using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Ninject;
using Ninject.Modules;

namespace BasicECommerce.Core.Utilities.Mvc.Infrascructure
{
    public class NinjectDependencyResolver:IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinjectDependencyResolver(INinjectModule module)
        {
            _kernel = new StandardKernel(module);
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }
    }
}
