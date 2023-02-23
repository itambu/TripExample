using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TripExample.DAL
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        private ICollection<T> _items;

        private int _count;

        public BaseRepository(FileStream stream, DriverSerializer ) 
        {
            
        }

        //protected abstract T CreateInstance(string s);
        //protected abstract void Instance(T instance);

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get()
        {
            return _items;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
