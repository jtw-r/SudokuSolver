using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver_Try1 {
	public class Board {

		public Tile[,] tiles;
		public int width;
		public int height;

		public Board(int _w, int _h) {
			this.width = _w;
			this.height = _h;

			tiles = new Tile[width, height];

			for (int x = 0; x < width; x++) {
				for (int y = 0; y < height; y++) {
					tiles[x, y] = new Tile(x, y, Tile.TileType.Empty, "", new List<string>(), null);
				}
			}

		}

		public Tile GetTile(int _x, int _y, bool isFromTable = true) {
			if (isFromTable) {
				var cord = TableToTile(_x, _y);
				return tiles[cord[0], cord[1]];
			} else {
				return tiles[_x, _y];
			}
		}

		/// <summary>
		/// Converts Table cordinates to Tile Array cordinates.
		/// Will convert 10,10 -> 8,8 or 4,4 -> 3,3 or 0,0 -> 0,0
		/// </summary>
		/// <param name="_x"></param>
		/// <param name="_y"></param>
		/// <returns></returns>
		public List<int> TableToTile(int _x, int _y) {
			// Will convert 10,10 -> 9,9 or 4,4 -> 3,3 or 0,0 -> 0,0
			List<int> cords = new List<int>();

			if (_x > 10) {
				_x = 10;
			}
			if (_y > 10) {
				_y = 10;
			}

			int x_offset = _x / 4;
			int y_offset = _y / 4;

			cords.Add(_x - (x_offset));
			cords.Add(_y - (y_offset));

			return cords;
		}

	}
}
