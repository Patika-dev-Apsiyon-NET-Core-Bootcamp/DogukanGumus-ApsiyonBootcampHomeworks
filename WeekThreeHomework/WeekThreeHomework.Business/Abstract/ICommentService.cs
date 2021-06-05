using System.Collections.Generic;
using WeekThreeHomework.Entities.Concrete;

namespace WeekThreeHomework.Business.Abstract
{
    public interface ICommentService
    {
        List<Comment> GetAll();
        Comment Get(int id);
        void Add(Comment comment);
        void Update(Comment comment);
        void Delete(Comment comment);
    }
}