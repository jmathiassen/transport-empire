using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportEmpire.Classes.Map;

namespace Classes.Objects.Infrastructure
{
    internal class Railroad
    {
        public List<Railroad> Tracks { get; set; }
        public Connection Start { get; set; }
        public Connection End { get; set; }
    }
    internal class Track : Object
    {

    }
    internal class Connection
    {
        public int Id { get; set; }
        public Cell Location { get; set; }
    }
}
