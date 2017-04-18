using System;
using System.Collections.Generic;

namespace SudokuSolver_Try1 {
	public class Board {

		public Tile[,] tiles;
		public int width;
		public int height;

		public Board(int x_length, int y_length) {
			this.width = x_length;
			this.height = y_length;

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

			if ((Math.Floor((float)(_x + 1) / 4) == ((float)(_x + 1) / 4)) || (Math.Floor((float)(_y + 1) / 4) == ((float)(_y + 1) / 4))) {
				cords.Add(0);
				cords.Add(0);
				return cords;
			} else {

				int x_offset = _x / 4;
				int y_offset = _y / 4;

				cords.Add(_x - (x_offset));
				cords.Add(_y - (y_offset));

				return cords;
			}
		}

		public List<int> TileToTable(int _x, int _y) {
			List<int> cords = new List<int>();

			int x_offset = (int)Math.Floor((float)(_x / 4));
			int y_offset = (int)Math.Floor((float)(_y / 4));

			cords.Add(_x + x_offset);
			cords.Add(_y + y_offset);

			return cords;
		}

	}
}
