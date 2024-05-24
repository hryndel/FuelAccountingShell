using FuelAccountingShell.Models.Enums;
using System;

namespace FuelAccountingShell.Models.User
{
    public class UserRequest
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Patronymic { get; set; }

        public string Mail { get; set; } = string.Empty;

        public string Login { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public UserTypes UserType { get; set; } = UserTypes.Employee;
    }
}
