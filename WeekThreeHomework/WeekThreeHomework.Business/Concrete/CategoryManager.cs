using System.Collections.Generic;
using WeekThreeHomework.Business.Abstract;
using WeekThreeHomework.DataAccess.Abstract;
using WeekThreeHomework.Entities.Concrete;

namespace WeekThreeHomework.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category Get(int id)
        {
            return _categoryDal.Get(c => c.Id == id);
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }
    }
}