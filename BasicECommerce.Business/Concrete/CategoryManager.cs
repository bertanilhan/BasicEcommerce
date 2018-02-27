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
    public class CategoryManager:ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(c => c.CategoryId == id);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
