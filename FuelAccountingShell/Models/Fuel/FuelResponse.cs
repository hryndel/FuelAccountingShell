using System;

namespace FuelAccountingShell.Models.Fuel
{
    public class FuelResponse
    {
        public Guid Id { get; set; }

        public string FuelType { get; set; } = string.Empty;

        public double Price { get; set; }

        public string Supplier { get; set; } = string.Empty;

        public double Count { get; set; }
    }
}
