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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contact;

        public ContactManager(IContactDal contactDal)
        {
            _contact = contactDal;
        }

        public void TDelete(int id)
        {
            _contact.Delete(id);
        }

        public List<Contact> TGetAll()
        {
            return _contact.GetAll();    
        }

        public Contact TGetById(int id)
        {
            return _contact.GetById(id);
        }

        public void TInsert(Contact entity)
        {
            _contact.Insert(entity);
        }

        public void TUpdate(Contact entity)
        {
            _contact.Update(entity); 
        }
    }
}
