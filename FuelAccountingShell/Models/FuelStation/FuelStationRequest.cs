﻿using System;

namespace FuelAccountingShell.Models.FuelStation
{
    public class FuelStationRequest
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string Description { get; set; }
    }
}
