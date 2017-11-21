using System;
using System.Collections.Generic;
using System.Text;
using ComputerStore.Entities;
using ComputerStore.DAL.Interface;

namespace ComputerStore.BLL
{
    public class ProductsManager : IProductsManager
    {
        /// <summary>
        /// TODO: Finishing doing EF Core repo
        /// </summary>
        //private IRepository<Computer> _computerRepository;

        //public ProductsManager(IRepository<Computer> computerRepository)
        //{
        //    this._computerRepository = computerRepository;
        //}

        private IComputerRepository _computerRepository;

        public ProductsManager(IComputerRepository computerRepository)
        {
            this._computerRepository = computerRepository;
        }

        public Computer GetComputerDetail(int Id)
        {
            return _computerRepository.GetByID(Id);
        }

        public IEnumerable<Computer> GetComputers()
        {
            return _computerRepository.GetAll();
        }
    }
}
