using System;

namespace FuelAccountingShell.Models.Truck
{
    public class TruckRequest
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Number { get; set; } = string.Empty;

        public string Vin { get; set; } = string.Empty;
    }
}
