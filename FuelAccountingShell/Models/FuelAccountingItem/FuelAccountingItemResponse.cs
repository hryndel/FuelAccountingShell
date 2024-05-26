using FuelAccountingShell.Models.Driver;
using FuelAccountingShell.Models.Fuel;
using FuelAccountingShell.Models.FuelStation;
using FuelAccountingShell.Models.Trailer;
using FuelAccountingShell.Models.Truck;
using System;

namespace FuelAccountingShell.Models.FuelAccountingItem
{
    public class FuelAccountingItemResponse
    {
        public Guid Id { get; set; }

        public DriverResponse Driver { get; set; }

        public TruckResponse Truck { get; set; }

        public TrailerResponse Trailer { get; set; }

        public FuelResponse Fuel { get; set; }

        public double Count { get; set; }

        public FuelStationResponse FuelStation { get; set; }

        public DateTimeOffset StartDate { get; set; }

        public DateTimeOffset EndDate { get; set; }
    }
}
