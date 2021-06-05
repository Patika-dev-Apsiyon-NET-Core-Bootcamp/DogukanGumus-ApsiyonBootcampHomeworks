using System.Collections;
using System.Collections.Generic;
using WeekThreeHomework.Core.Entities;

namespace WeekThreeHomework.Entities.Concrete
{
    public class Category:IEntity
    {
        public Category()
        {
            Articles = new List<Article>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}