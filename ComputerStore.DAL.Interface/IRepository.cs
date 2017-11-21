using System;
using System.Collections.Generic;

namespace ComputerStore.DAL.Interface
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetByID(int id);
    }
}
