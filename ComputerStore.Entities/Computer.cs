using System;

namespace ComputerStore.Entities
{
    public class Computer
    {
        public int ID { get; set; }
        public ComputerType ComputerType { get; set; }
        public string Brand { get; set; }
        public int NumCPU { get; set; }
        public decimal CPUSpeed { get; set; }
        public int RAM { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
    }
}
