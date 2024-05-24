using FuelAccountingShell.Models.Enums;
using System;

namespace FuelAccountingShell.Models.Fuel
{
    public class FuelRequest
    {
        public Guid Id { get; set; }

        public FuelTypes FuelType { get; set; } = FuelTypes.Petrol92;

        public double Price { get; set; }

        public Guid SupplierId { get; set; }

        public double Count { get; set; }
    }
}
