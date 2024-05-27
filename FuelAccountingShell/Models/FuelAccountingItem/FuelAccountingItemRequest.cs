using System;

namespace FuelAccountingShell.Models.FuelAccountingItem
{
    public class FuelAccountingItemRequest
    {
        public Guid Id { get; set; }

        public Guid DriverId { get; set; }

        public Guid TruckId { get; set; }

        public Guid TrailerId { get; set; }

        public Guid FuelId { get; set; }

        public double Count { get; set; }

        public Guid FuelStationId { get; set; }

        public DateTimeOffset StartDate { get; set; }

        public DateTimeOffset EndDate { get; set; }
    }
}
