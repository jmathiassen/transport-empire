using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportEmpire.Classes.Map;

namespace Classes.Objects.Infrastructure
{
    internal class Waypoint
    {
        public int Id { get; set; }
        public Cell Location { get; set; }
    }
}
