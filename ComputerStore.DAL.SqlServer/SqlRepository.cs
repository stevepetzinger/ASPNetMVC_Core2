using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ComputerStore.DAL.SqlServer
{
    public class SqlRepository<T> : DAL.Interface.IRepository<T> where T : class
    {
        protected readonly DbContext Context;
        protected DbSet<T> DbSet;

        public SqlRepository(ComputerStoreContext context)
        {
            Context = context;
            DbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);

            Save();
        }

        public void Delete(T entity)
        {
            Context.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return DbSet;
        }

        public T GetByID(int id)
        {
            return DbSet.Find(id);
        }

        public void Update(T entity)
        {
            Save();
        }

        private void Save()
        {
            Context.SaveChanges();
        }
    }
}
