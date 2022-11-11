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
	public class AboutManager : IAboutService
	{
		private readonly IAboutDal _aboutDal;

		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public void Delete(About item)
		{
			_aboutDal.Delete(item);
		}

		public About GetById(int id)
		{
			return _aboutDal.GetById(id);
		}

		public List<About> GetListAll()
		{
			return _aboutDal.GetListAll();
		}

		public void Insert(About item)
		{
			_aboutDal.Insert(item);
		}

		public void Update(About item)
		{
			_aboutDal.Update(item);
		}
	}
}
