using System;
using System.Collections.Generic;
using ComputerStore.DAL.Interface;
using ComputerStore.Entities;

namespace ComputerStore.DAL.Mocks
{
    public class MockComputerRepository : IComputerRepository
    {
        public void Add(Computer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Computer entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Computer> GetAll()
        {
            var computers = new List<Entities.Computer>();
            for (int i = 1; i < 20; i++)
            {
                computers.Add(new Entities.Computer
                {
                    Brand = $"Brand{i}",
                    ComputerType = new Entities.ComputerType { ID = 1, TypeName = "Laptop" },
                    CPUSpeed = i * 100,
                    Discount = (decimal)i / 100,
                    ID = i,
                    NumCPU = i,
                    Price = i * 100,
                    RAM = i * 100
                });
            }

            return computers;
        }

        public Computer GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Computer entity)
        {
            throw new NotImplementedException();
        }
    }
}
