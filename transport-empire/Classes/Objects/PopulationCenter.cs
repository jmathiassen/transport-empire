using TransportEmpire.Classes.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportEmpire.Classes.Objects
{
	internal class PopulationCenter
	{
		public string Name { get; set; }
		public int Id { get; set; }
		public int Population { get; set; }
		public List<Road> Roads { get; set; }
		public TrainStation TrainStation { get; set; }
		public List<Industry> Industries { get; set; }
	}
}
