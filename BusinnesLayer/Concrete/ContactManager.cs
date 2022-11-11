using BusinnesLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Delete(Contacts item)
        {
            _contactDal.Delete(item);
        }

        public Contacts GetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contacts> GetListAll()
        {
            return _contactDal.GetListAll();
        }

        public void Insert(Contacts item)
        {
            _contactDal.Insert(item);
        }

        public void Update(Contacts item)
        {
            _contactDal.Update(item);
        }
    }
}
