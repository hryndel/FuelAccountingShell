using System.ComponentModel;

namespace FuelAccountingShell.Models.Enums
{
    public enum FuelTypes
    {
        [Description("АИ-92")]
        Petrol92,

        [Description("АИ-95")]
        Petrol95,

        [Description("АИ-98")]
        Petrol98,

        [Description("АИ-100")]
        Petrol100,

        [Description("Дизель")]
        Disel
    }
}
