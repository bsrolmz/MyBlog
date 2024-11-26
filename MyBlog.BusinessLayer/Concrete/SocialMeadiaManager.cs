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
    public class SocialMeadiaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMedia;

        public SocialMeadiaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMedia = socialMediaDal;
        }

        public void TDelete(int id)
        {
            _socialMedia.Delete(id);
        }

        public List<SocialMedia> TGetAll()
        {
            return _socialMedia.GetAll();    
        }

        public SocialMedia TGetById(int id)
        {
           return _socialMedia.GetById(id);
        }

        public void TInsert(SocialMedia entity)
        {
            _socialMedia.Insert(entity); 
        }

        public void TUpdate(SocialMedia entity)
        {
           _socialMedia.Update(entity);
        }
    }
}
