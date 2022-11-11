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
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void AnnouncementStatusToFalse(int id)
        {
            _announcementDal.AnnouncementStatusToFalse(id);
        }

        public void AnnouncementStatusToTrue(int id)
        {
            _announcementDal.AnnouncementStatusToTrue(id);
        }

        public void Delete(Announcement item)
        {
            _announcementDal.Delete(item);
        }

        public Announcement GetById(int id)
        {
           return _announcementDal.GetById(id);
        }

        public List<Announcement> GetListAll()
        {
            return _announcementDal.GetListAll();
        }

        public void Insert(Announcement item)
        {
            _announcementDal.Insert(item);
        }

        public void Update(Announcement item)
        {
            _announcementDal.Update(item);
        }
    }
}
