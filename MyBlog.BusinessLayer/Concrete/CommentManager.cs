using MyBlog.BusinessLayer.Abstract;
using MyBlog.DataAccessLayer.Abstract;
using MyBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _comment;

        public CommentManager(ICommentDal commentdal)
        {
            _comment = commentdal;
        }

        public void TDelete(int id)
        {
            _comment.Delete(id);
        }

        public List<Comment> TGetAll()
        {
            return _comment.GetAll();
        }

        public Comment TGetById(int id)
        {
            return _comment.GetById(id);
        }

        public void TInsert(Comment entity)
        {
            _comment.Insert(entity); 
        }

        public void TUpdate(Comment entity)
        {
            _comment.Update(entity); 
        }
    }
}
