using FuelAccountingShell.Models.Enums;
using FuelAccountingShell.Models.Supplier;
using System;

namespace FuelAccountingShell.Models.Fuel
{
    public class FuelResponse
    {
        public Guid Id { get; set; }

        public FuelTypes FuelType { get; set; } = FuelTypes.Petrol92;

        public double Price { get; set; }

        public SupplierResponse Supplier { get; set; }

        public double Count { get; set; }
    }
}
