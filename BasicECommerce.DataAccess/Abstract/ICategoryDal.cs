using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicECommerce.Core.DataAccess;
using BasicECommerce.Entities.Concrete;

namespace BasicECommerce.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
