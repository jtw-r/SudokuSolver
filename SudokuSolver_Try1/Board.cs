using System;
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
					tiles[x, y] = new Tile(x, y, Tile.TileType.Empty, "", new List<string>(), null, null, false,width,height);
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

		public List<Tile> GetGroup(int _group) {
			List<Tile> tileGroup = new List<Tile>();
			for (int x = 0; x < width; x++) {
				for (int y = 0; y < height; y++) {
					if (tiles[x,y].group == _group) {
						tileGroup.Add(tiles[x, y]);
					}
				}
			}
			return tileGroup;
		}

		public void Clear() {
			for (int x = 0; x < width; x++) {
				for (int y = 0; y < height; y++) {
					Tile t = tiles[x, y];
					if (t.hasField) {
						t.field.Text = "";
					}
				}
			}
		}

		public void LoadDataset(int num) {
			Data d = new Data();

			for (int x = 0; x < 9; x++) {
				for (int y = 0; y < 9; y++) {
					int x_offset = (int)(x / Math.Sqrt(9));
					int y_offset = (int)(y / Math.Sqrt(9));

					var value = d.presets[Clamp(num, 0, d.entries - 1), x, y];

					if (value == " ") {
						value = "";
					}

					tiles[x + x_offset, y + y_offset].field.Text = value;

				}
			}

		}

		public int Clamp(int num, int min, int max) {
			if (num < min) {
				num = min;
			} else if (num > max) {
				num = max;
			}

			return num;
		}

	}
}
