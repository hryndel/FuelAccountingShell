using FuelAccountingShell.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelAccountingShell.Models.Token
{
    public class TokenResponse
    {
        public UserTypes UserType { get; set; } = UserTypes.Employee;

        public string Token { get; set; }
    }
}
