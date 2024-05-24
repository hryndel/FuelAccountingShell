using System;

namespace FuelAccountingShell.Models.Driver
{
    public class DriverResponse
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Patronymic { get; set; }

        public string Phone { get; set; } = string.Empty;

        public string DriversLicense { get; set; } = string.Empty;
    }
}
