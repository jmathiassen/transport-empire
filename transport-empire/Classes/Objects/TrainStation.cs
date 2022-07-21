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
		public int Id { get; set; }
		public string Name { get; set; }
		public int Population { get; set; }
		public List<Industry> Industries { get; set; }
	}
}
