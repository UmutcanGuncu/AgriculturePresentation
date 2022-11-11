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
	public class SocialMediaManager : ISocialMediaService
	{
		private readonly ISocialMediaDal _socialMediaDal;

		public SocialMediaManager(ISocialMediaDal socialMediaDal)
		{
			_socialMediaDal = socialMediaDal;
		}

		public void Delete(SocialMedia item)
		{
			_socialMediaDal.Delete(item); ;
		}

		public SocialMedia GetById(int id)
		{
			return _socialMediaDal.GetById(id);
		}

		public List<SocialMedia> GetListAll()
		{
			return _socialMediaDal.GetListAll();
		}

		public void Insert(SocialMedia item)
		{
			_socialMediaDal.Insert(item);
		}

		public void Update(SocialMedia item)
		{
			_socialMediaDal.Update(item);
		}
	}
}
