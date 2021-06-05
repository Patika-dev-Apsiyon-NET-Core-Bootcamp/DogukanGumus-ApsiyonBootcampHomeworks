using System.Collections.Generic;
using System.Linq;
using BookInSession.Models;

namespace BookInSession.Database
{
    public class Categories
    {
        private List<CategoryModel> _categories;

        public Categories()
        {
            _categories = new List<CategoryModel>()
            {
                new CategoryModel(){Id=1, CategoryName = "Korku/Gerilim"},
                new CategoryModel(){Id=2, CategoryName = "Dünya Roman"},
                new CategoryModel(){Id=3, CategoryName = "Yerli"},
            };
        }
        public List<CategoryModel> GetAll()
        {
            return _categories;
        }
        
        public CategoryModel GetById(int categoryId)
        {
            return _categories.SingleOrDefault(b=>b.Id == categoryId);
        }
        

        public void Add(CategoryModel categoryModel)
        {
            _categories.Add(categoryModel);
        }

        public void Delete(CategoryModel categoryModel )
        {
            var categoryToDelete = _categories.SingleOrDefault(b => b.Id == categoryModel.Id);
            if (categoryToDelete != null)
            {
                _categories.Remove(categoryToDelete);
            }
        }

        public void Update(CategoryModel categoryModel )
        {
            var categoryToUpdate = _categories.SingleOrDefault(b => b.Id == categoryModel.Id);
            if (categoryToUpdate!=null)
            {
                categoryToUpdate.CategoryName = categoryModel.CategoryName;
            }
        }
    }
}