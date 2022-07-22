using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportEmpire.Classes.Map;

namespace Classes.Objects.Infrastructure
{
    internal class Object
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public Junction Start { get; set; }
        public Junction End { get; set; }
    }
}
