using Classes.Objects;
using Classes.Objects.Buildings;
using Classes.Objects.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportEmpire.Classes.Map;

namespace TransportEmpire.Classes.Objects
{
	internal class Planet : UniverseObject
	{
		private Terrain _terrain;
		public List<PopulationCenter> PopulationCentres;
		public List<Industry> Industries;
		public List<Track> Tracks;
		public List<ShipLane> ShipLanes;
		public List<AirLane> AirLanes;
	}
}
