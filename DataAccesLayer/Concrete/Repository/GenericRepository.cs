using DataAccesLayer.Abstract;
using DataAccesLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        public void Delete(T item)
        {
            using var context = new AgricultureContext();
            context.Remove(item);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            using var context = new AgricultureContext();
            return context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var context = new AgricultureContext();
            return context.Set<T>().ToList();
        }

        public void Insert(T item)
        {
            using var context = new AgricultureContext();
            context.Add(item);
            context.SaveChanges();
        }

        public void Update(T item)
        {
            using var context = new AgricultureContext();
            context.Update(item);
            context.SaveChanges();
        }
    }
}
