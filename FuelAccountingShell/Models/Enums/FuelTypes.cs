using System.ComponentModel;

namespace FuelAccountingShell.Models.Enums
{
    public enum FuelTypes
    {
        [Description("Бензин 92 пробы")]
        Petrol92,

        [Description("Бензин 95 пробы")]
        Petrol95,

        [Description("Бензин 98 пробы")]
        Petrol98,

        [Description("Бензин 100 пробы")]
        Petrol100,

        [Description("Дизель")]
        Disel
    }
}
