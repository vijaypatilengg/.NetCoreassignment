using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Abstraction
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int ID);
       void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
