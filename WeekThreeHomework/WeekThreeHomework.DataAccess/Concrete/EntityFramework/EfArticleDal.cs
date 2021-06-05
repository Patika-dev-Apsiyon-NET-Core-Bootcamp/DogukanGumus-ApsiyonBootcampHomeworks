using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WeekThreeHomework.Core.DataAccess.Concrete.EntityFramework;
using WeekThreeHomework.DataAccess.Abstract;
using WeekThreeHomework.Entities.Concrete;

namespace WeekThreeHomework.DataAccess.Concrete.EntityFramework
{
    public class EfArticleDal:EfEntityRepositoryBase<Article,WeekThreeHomeworkContext>, IArticleDal
    {
        public Article GetArticleWithComments(int id)
        {
            using (WeekThreeHomeworkContext context = new WeekThreeHomeworkContext())
            {
                return context.Articles.Where(a => a.Id == id)
                    .Include(c => c.Comments)
                    .SingleOrDefault();
            }
        }
    }
}