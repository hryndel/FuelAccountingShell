using System;

namespace FuelAccountingShell.Models.FuelAccountingItem
{
    public class FuelAccountingItemResponse
    {
        public Guid Id { get; set; }

        public string Driver { get; set; } = string.Empty;

        public string Truck { get; set; } = string.Empty;

        public string Trailer { get; set; } = string.Empty;

        public string Fuel { get; set; } = string.Empty;

        public double Count { get; set; }

        public string FuelStation { get; set; } = string.Empty;

        public DateTimeOffset StartDate { get; set; }

        public DateTimeOffset EndDate { get; set; }
    }
}
