
using Classes.Objects;
using Classes.Objects.Buildings;
using Classes.Objects.Infrastructure;

namespace TransportEmpire.Classes.Objects
{
	internal class PopulationCenter : UniverseObject
	{
		public List<UniverseObject> Buildings { get; set; }
		public List<Road> Roads { get; set; }
		public RailwayStation TrainStation { get; set; }
	}
}
