using System.Collections.Generic;
using WeekThreeHomework.Business.Abstract;
using WeekThreeHomework.DataAccess.Abstract;
using WeekThreeHomework.Entities.Concrete;

namespace WeekThreeHomework.Business.Concrete
{
    public class ArticleManager:IArticleService
    {
        private readonly IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public List<Article> GetAll()
        {
            return _articleDal.GetAll();
        }

        public List<Article> GetByCategoryId(int categoryId)
        {
            return _articleDal.GetAll(c=>c.CategoryId == categoryId || categoryId == 0);
        }

        public Article GetArticleWithComments(int id)
        {
            return _articleDal.GetArticleWithComments(id);
        }

        public Article Get(int id)
        {
            return _articleDal.Get(a=>a.Id == id);
        }

        public void Add(Article article)
        {
            _articleDal.Add(article);
        }

        public void Update(Article article)
        {
            _articleDal.Update(article);
        }

        public void Delete(Article article)
        {
            _articleDal.Delete(article);
        }
    }
}