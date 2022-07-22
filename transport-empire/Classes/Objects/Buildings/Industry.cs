﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportEmpire.Classes.Map;

namespace Classes.Objects.Buildings
{
    internal class Industry : UniverseObject
    {
        public List<Warehouse> Warehouses { get; set; }
    }
}
