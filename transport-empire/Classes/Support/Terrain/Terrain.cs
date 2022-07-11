using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportEmpire.Classes.Map
{
	public class Terrain
	{
		private List<Cell> _terrain { get; set; }
		public int _maxX { get; set; }
		public int _maxY { get; set; }

		public Terrain()
		{
			_terrain = new();
		}
		public Terrain(float[,] terrain)
		{
			_terrain = new();
			this.SetTerrain(terrain);
		}

		public void SetTerrain(float[,] terrain)
		{
			this._maxX = terrain.GetLength(0) - 1;
			this._maxY = terrain.GetLength(1) - 1;
			Cell[,] tempTerrain = new Cell[_maxX+1, _maxY+1];

			for (int x = 0; x <= _maxX;x++)
			{
				for (int y = 0;y <= _maxY;y++)
				{
					tempTerrain[x, y] = new Cell(x, y, (byte)terrain[x, y]);
				}
			}

			for (int x = 0; x <= _maxX; x++)
			{
				for (int y = 0; y <= _maxY; y++)
				{
					if (x > 0) tempTerrain[x, y].Left		= tempTerrain[x - 1, y];
					if (x < _maxX) tempTerrain[x, y].Right	= tempTerrain[x + 1, y];
					if (y > 0) tempTerrain[x, y].Up			= tempTerrain[x, y - 1];
					if (y < _maxY) tempTerrain[x, y].Down	= tempTerrain[x, y + 1];

					_terrain.Add(tempTerrain[x, y]);
				}
			}


		}

		public Cell? GetAt(int x, int y)
		{
			if (x >= 0 && y >= 0 && x < this._maxX && y < this._maxY)
			{
				foreach (Cell cell in _terrain)
					if (cell.X == x && cell.Y == y)
						return cell;
			}

			return null;
		}
	}
}
