using System.Collections.Generic;
using WeekThreeHomework.Entities.Concrete;

namespace WeekThreeHomework.Business.Abstract
{
    public interface IArticleService
    {
        List<Article> GetAll();
        List<Article> GetByCategoryId(int categoryId);
        Article GetArticleWithComments(int id);
        Article Get(int id);
        void Add(Article article);
        void Update(Article article);
        void Delete(Article article);
    }
}