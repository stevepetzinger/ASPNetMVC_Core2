using System;

namespace ComputerStore.Entities
{
    public class State
    {
        public int ID { get; set; }
        public string Abbreviation { get; set; }
        public string Name { get; set; }
        public decimal TaxRate { get; set; }
    }
}
