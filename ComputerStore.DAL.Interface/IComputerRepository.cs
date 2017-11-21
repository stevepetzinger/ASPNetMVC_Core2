using System;
using System.Collections.Generic;
using System.Text;
using ComputerStore.Entities;

namespace ComputerStore.DAL.Interface
{
    public interface IComputerRepository
    {
        IEnumerable<Computer> GetAll();
        void Add(Computer entity);
        void Delete(Computer entity);
        void Update(Computer entity);
        Computer GetByID(int id);
    }
}
