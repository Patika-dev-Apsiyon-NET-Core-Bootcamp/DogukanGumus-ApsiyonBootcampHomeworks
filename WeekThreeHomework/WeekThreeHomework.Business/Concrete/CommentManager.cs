using System.Collections.Generic;
using WeekThreeHomework.Business.Abstract;
using WeekThreeHomework.DataAccess.Abstract;
using WeekThreeHomework.Entities.Concrete;

namespace WeekThreeHomework.Business.Concrete
{
    public class CommentManager:ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> GetAll()
        {
            return _commentDal.GetAll();
        }

        public Comment Get(int id)
        {
            return _commentDal.Get(c => c.Id == id);
        }

        public void Add(Comment comment)
        {
           _commentDal.Add(comment);
        }

        public void Update(Comment comment)
        {
            _commentDal.Update(comment);
        }

        public void Delete(Comment comment)
        {
            _commentDal.Delete(comment);
        }
    }
}