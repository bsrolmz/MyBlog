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
    public class TagCloudManager : ITagCloudService
    {
        private readonly ITagCloudDal _tagCloud;

        public TagCloudManager(ITagCloudDal tagCloud)
        {
            _tagCloud = tagCloud;
        }

        public void TDelete(int id)
        {
            _tagCloud.Delete(id);   
        }

        public List<TagCloud> TGetAll()
        {
            return _tagCloud.GetAll();  
        }

        public TagCloud TGetById(int id)
        {
            return _tagCloud.GetById(id);
        }

        public void TInsert(TagCloud entity)
        {
            _tagCloud.Insert(entity);
        }

        public void TUpdate(TagCloud entity)
        {
            _tagCloud.Update(entity);
        }
    }
}
