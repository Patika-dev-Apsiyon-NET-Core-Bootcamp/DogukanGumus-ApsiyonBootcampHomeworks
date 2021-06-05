using System.Collections.Generic;
using WeekThreeHomework.Entities.Concrete;

namespace WeekThreeHomework.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category Get(int id);
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}