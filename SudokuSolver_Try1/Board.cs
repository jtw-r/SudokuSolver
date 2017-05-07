using System;
using System.Collections.Generic;
using System.IO;

namespace SudokuSolver_Try1 {
	public class Board {

		private Tile[,] tiles;
		private int width;
		private int height;

		public int Height {
			get {
				return height;
			}
		}

		public int Width {
			get {
				return width;
			}
		}

		public Board(int x_length, int y_length) {
			this.width = y_length;
			this.height = x_length;

			tiles = new Tile[Width, Height];

			for (int x = 0; x < Width; x++) {
				for (int y = 0; y < Height; y++) {
					tiles[x, y] = new Tile(x, y, Tile.TileType.Empty, "", new List<string>(), null, null, false,Width,Height);
				}
			}

		}

		public Tile GetTile(int _x, int _y, bool isFromTable = true) {
			return tiles[_x, _y];
		}

		public List<Tile> GetRow(int row) {
			List<Tile> tileRow = new List<Tile>();
			for (int y = 0; y < Height; y++) {
				tileRow.Add(tiles[row,y]);
			}
			return tileRow;
		}

		public List<Tile> GetColumn(int column) {
			List<Tile> tileColumn = new List<Tile>();
			for (int x = 0; x < Width; x++) {
				tileColumn.Add(tiles[x, column]);
			}
			return tileColumn;
		}

		public List<Tile> GetGroup(int _group) {
			List<Tile> tileGroup = new List<Tile>();
			for (int x = 0; x < Width; x++) {
				for (int y = 0; y < Height; y++) {
					if (tiles[x,y].group == _group) {
						tileGroup.Add(tiles[x, y]);
					}
				}
			}
			return tileGroup;
		}

		public void Clear() {
			for (int x = 0; x < Width; x++) {
				for (int y = 0; y < Height; y++) {
					Tile t = tiles[x, y];
					if (t.hasField) {
						t.field.Text = "";
					}
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

		public int FindOccurance(string str) {
			int occ = 0;

			for (int x = 0; x < Width; x++) {
				for (int y = 0; y < Height; y++) {
					if (tiles[x,y].hasField) {
						if (tiles[x,y].field.Text == str) {
							occ++;
						}
					}
				}
			}

			return occ;
		}

		/// <summary>
		/// Gets the possible spaces for a number.
		/// </summary>
		/// <param name="num">The number to check.</param>
		/// <returns></returns>
		public int[,] GetPossibilities(string num) {

			int[,] possibilities = new int[Width, Height];

			for (int x = 0; x < Width; x++) {
				for (int y = 0; y < Height; y++) {

					if (GetTile(x, y).value == "" && GetTile(x, y).hasField) {
						var column = GetColumn(y);
						var row = GetRow(x);
						var group = GetGroup(GetTile(x, y).group);

						possibilities[x, y] = 1;

						for (int a = 0; a < column.Count; a++) {
							if (column[a].value == num) {
								possibilities[x, y] = 0;
							}
						}

						for (int b = 0; b < row.Count; b++) {
							if (row[b].value == num) {
								possibilities[x, y] = 0;
							}
						}

						for (int c = 0; c < group.Count; c++) {
							if (group[c].x != x && group[c].y != y && group[c].value == num) {
								possibilities[x, y] = 0;
							}
						}
					}
				}
			}

			return possibilities;
		}

	}
}
