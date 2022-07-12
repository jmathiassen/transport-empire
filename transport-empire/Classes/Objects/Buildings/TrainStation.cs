using TransportEmpire.Classes.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Objects.Buildings
{
    internal class TrainStation
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Warehouse> Warehouses { get; set; }
    }
}
