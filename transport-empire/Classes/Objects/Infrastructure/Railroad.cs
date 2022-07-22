using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportEmpire.Classes.Map;

namespace Classes.Objects.Infrastructure
{
    internal class RailwayStation
	{
        public List<Platform> Platforms { get; set; }
    }
    internal class Railway
    {
        public Junction Start { get; set; }
        public Junction End { get; set; }
    }
    internal class Platform
    {
        public Track TrackLeft { get; set; }
        public Track TrackRight { get; set; }

    }
    internal class Track
    {

    }
    internal class Junction
    {
        public int Id { get; set; }
    }
}
