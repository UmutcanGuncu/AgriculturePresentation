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
    public class AdressManager : IAdressService
    {
        IAdressDal _adressDal;

        public AdressManager(IAdressDal adressDal)
        {
            _adressDal = adressDal;
        }

        public void Delete(Adress item)
        {
            _adressDal.Delete(item);

        }

        public Adress GetById(int id)
        {
            return _adressDal.GetById(id);
        }

        public List<Adress> GetListAll()
        {
            return _adressDal.GetListAll();
        }

        public void Insert(Adress item)
        {
           _adressDal.Insert(item);
        }

        public void Update(Adress item)
        {
            _adressDal.Update(item);
        }
    }
}
