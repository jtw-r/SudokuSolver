using System.Collections.Generic;

namespace SudokuSolver_Try1 {
	public class Board {

		public Tile[,] tiles;
		public int width;
		public int height;

		public Board(int x_length, int y_length) {
			this.width = y_length;
			this.height = x_length;

			tiles = new Tile[width, height];

			for (int x = 0; x < width; x++) {
				for (int y = 0; y < height; y++) {
					tiles[x, y] = new Tile(x, y, Tile.TileType.Empty, "", new List<string>(), null, null, false);
				}
			}

		}

		public Tile GetTile(int _x, int _y, bool isFromTable = true) {
			return tiles[_x, _y];
		}

		public List<Tile> GetRow(int row) {
			List<Tile> tileRow = new List<Tile>();
			for (int y = 0; y < height; y++) {
				tileRow.Add(tiles[row,y]);
			}
			return tileRow;
		}

		public List<Tile> GetColumn(int column) {
			List<Tile> tileColumn = new List<Tile>();
			for (int x = 0; x < width; x++) {
				tileColumn.Add(tiles[x, column]);
			}
			return tileColumn;
		}

	}
}
