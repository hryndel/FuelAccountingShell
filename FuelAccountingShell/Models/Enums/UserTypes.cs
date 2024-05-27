using System.ComponentModel;

namespace FuelAccountingShell.Models.Enums
{
    public enum UserTypes
    {
        [Description("Сотрудник")]
        Employee,

        [Description("Менеджер")]
        Manager,

        [Description("Администратор")]
        Administrator
    }
}
