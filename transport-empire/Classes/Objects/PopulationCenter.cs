
namespace TransportEmpire.Classes.Objects
{
	internal class PopulationCenter
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Population { get; set; }
		public List<Road> Roads { get; set; }
		public TrainStation TrainStation { get; set; }
		public List<Industry> Industries { get; set; }
	}
}
