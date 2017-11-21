using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerStore.Web.Models
{
    public class ComputerVM
    {
        public int ID { get; set; }
        string ComputerTypeName { get; set; }
        public string Brand { get; set; }
        public int NumCPU { get; set; }
        public decimal CPUSpeed { get; set; }
        public int RAM { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }

        // Define implicit mapping between types
        public static implicit operator ComputerVM(Entities.Computer computer)
        {
            var vm = new ComputerVM
            {
                ID = computer.ID,
                Brand = computer.Brand,
                CPUSpeed = computer.CPUSpeed,
                Discount = computer.Discount,
                NumCPU = computer.NumCPU,
                Price = computer.Price,
                RAM = computer.RAM,
                ComputerTypeName = computer.ComputerType.TypeName
            };

            return vm;
        }

        public static implicit operator Entities.Computer(ComputerVM vm)
        {
            var entity = new Entities.Computer
            {
                ID = vm.ID,
                Brand = vm.Brand,
                CPUSpeed = vm.CPUSpeed,
                Discount = vm.Discount,
                NumCPU = vm.NumCPU,
                Price = vm.Price,
                RAM = vm.RAM
                // omitting computer type, as it cannot be implicitly translated
            };

            return vm;
        }
    }
}
