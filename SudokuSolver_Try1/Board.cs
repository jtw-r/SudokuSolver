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
					tiles[x, y] = new Tile(x, y, Tile.TileType.Empty, "", new List<string>());
				}
			}

		}

		public Tile GetTile(int _x, int _y) {
			int x_ = (int)Math.Floor((float)(_x+1)/3);
			int y_ = (int)Math.Floor((float)(_y+1)/3);
			return tiles[_x-x_, _y-y_];
		}

	}
}
