using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicECommerce.Entities.Concrete;

namespace BasicECommerce.Business.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int id);
        List<Category> GetAll();
    }
}
