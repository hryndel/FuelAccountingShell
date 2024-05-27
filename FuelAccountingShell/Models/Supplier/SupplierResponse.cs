using System;

namespace FuelAccountingShell.Models.Supplier
{
    public class SupplierResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Inn { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Description { get; set; }
    }
}
