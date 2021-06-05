using System.Collections;
using System.Collections.Generic;
using WeekThreeHomework.Core.Entities;

namespace WeekThreeHomework.Entities.Concrete
{
    public class Article:IEntity
    {
        public Article()
        {
            Comments = new List<Comment>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}