using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportEmpire.Classes.Map
{
	public class Cell
	{
		public int X { get; set; }
		public int Y { get; set; }
		public byte Z { get; set; }

		public Cell? Left { get; set; }
		public Cell? Right { get; set; }
		public Cell? Up { get; set; }
		public Cell? Down { get; set; }

		public Cell(int x, int y)
		{
			X = x;
			Y = y;
		}
		public Cell(int x, int y, byte z)
		{
			X = x;
			Y = y;
			Z = z; 
		}
	}
}
