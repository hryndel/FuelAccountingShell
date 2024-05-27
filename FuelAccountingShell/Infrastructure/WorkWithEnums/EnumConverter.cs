using System;

namespace FuelAccountingShell.Infrastructure.WorkWithEnums
{
    public class EnumConverter
    {
        public Enum Type { get; set; }

        public string DislplayValue { get; set; }

        public EnumConverter(Enum roleType)
        {
            this.Type = roleType;
            DislplayValue = roleType.EnumRead() ?? string.Empty;
        }
    }
}
