using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportEmpire.Classes.Map;

namespace Classes.Objects.Buildings
{
    internal class Industry
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Warehouse> Warehouses { get; set; }
    }
}
