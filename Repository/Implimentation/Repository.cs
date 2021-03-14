using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repository.Implimentation
{
    public class Repository<T> : IRepository<T> where T : class
    {

        private readonly DbContextConn _dbContextConn;
        public Repository(DbContextConn dbContextConn)
        {
             _dbContextConn = dbContextConn;
        }

        public void Add(T entity)
        {
            _dbContextConn.Add(entity);
            _dbContextConn.SaveChanges();

        }

        public void Delete(T entity)
        {
            _dbContextConn.Attach(entity);
            _dbContextConn.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContextConn.Set<T>().ToList();
        }

        public T GetById(int ID)
        {
            return _dbContextConn.Set<T>().Find(ID);
        }

        public void Update(T entity)
        {
            _dbContextConn.Attach(entity);
            _dbContextConn.Entry(entity).State = EntityState.Modified;
            _dbContextConn.SaveChanges();
        }
    }
}
