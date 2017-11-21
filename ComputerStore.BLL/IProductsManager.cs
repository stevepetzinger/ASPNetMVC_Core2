using System;
using System.Collections.Generic;
using System.Text;
using ComputerStore.Entities;

namespace ComputerStore.BLL
{
    public interface IProductsManager
    {
        IEnumerable<Computer> GetComputers();
        Computer GetComputerDetail(int Id);
    }
}
