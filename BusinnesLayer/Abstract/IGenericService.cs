using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Abstract
{
    public interface IGenericService<T> where T : class, new()
    {
        void Insert(T item);
        void Delete(T item);
        void Update(T item);
        T GetById(int id);
        List<T> GetListAll();
    }
}
