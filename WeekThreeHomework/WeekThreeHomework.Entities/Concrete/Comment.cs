using System.Collections;
using WeekThreeHomework.Core.Entities;

namespace WeekThreeHomework.Entities.Concrete
{
    public class Comment:IEntity
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}