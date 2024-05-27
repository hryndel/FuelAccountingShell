using System;

namespace FuelAccountingShell.Models.Trailer
{
    public class TrailerRequest
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Number { get; set; } = string.Empty;

        public double Capacity { get; set; }
    }
}
