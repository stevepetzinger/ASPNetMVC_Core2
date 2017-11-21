using System;
using System.Collections.Generic;
using System.Text;
using ComputerStore.DAL.Interface;

namespace ComputerStore.BLL
{
    public class PriceManager : IPriceManager
    {
        private IRepository<Entities.Computer> _computerRepo;
        private IRepository<Entities.State> _statesRepo;

        public PriceManager(IRepository<Entities.Computer> computerRepo, IRepository<Entities.State> statesRepo) {
            this._computerRepo = computerRepo;
            this._statesRepo = statesRepo;
        }

        public decimal GetPrice(int computerId, int stateId)
        {
            var computer = _computerRepo.GetByID(computerId);
            var computerPrice = computer.Price;
            var discount = computer.Discount;
            var taxRate = _statesRepo.GetByID(stateId).TaxRate;

            return computerPrice * discount ?? 1 * (1 + taxRate);
        }
    }
}
