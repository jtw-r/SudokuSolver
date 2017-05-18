using System;
using System.Collections.Generic;
using System.IO;

namespace SudokuSolver_Try1 {
	public class DataBoard {

		private Cell[,] cells;
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

		public DataBoard(int x_length, int y_length) {
			this.width = y_length;
			this.height = x_length;

			cells = new Cell[Width, Height];
			Reset();
			
		}

		public void Reset() {
			for (int x = 0; x < Width; x++) {
				for (int y = 0; y < Height; y++) {
					if (isSqrt(x, Width) == true || isSqrt(y, Height) == true) {
						cells[x, y] = new Cell(x, y, Width, Height, null);
					} else {
						cells[x, y] = new Cell(x, y, Width, Height, "");
					}
				}
			}
		}

		public Cell GetCell(int _x, int _y) { return cells[_x, _y]; }

		public List<Cell> GetRow(int row) {
			List<Cell> cellRow = new List<Cell>();
			for (int y = 0; y < Height; y++) {
				cellRow.Add(cells[row, y]);
			}
			return cellRow;
		}

		public List<Cell> GetColumn(int column) {
			List<Cell> CellColumn = new List<Cell>();
			for (int x = 0; x < Width; x++) {
				CellColumn.Add(cells[x, column]);
			}
			return CellColumn;
		}

		public List<Cell> GetGroup(int _group) {
			List<Cell> CellGroup = new List<Cell>();
			for (int x = 0; x < Width; x++) {
				for (int y = 0; y < Height; y++) {
					if (cells[x, y].Group == _group) {
						CellGroup.Add(cells[x, y]);
					}
				}
			}
			return CellGroup;
		}

		public void Clear() {
			for (int x = 0; x < Width; x++) {
				for (int y = 0; y < Height; y++) {
					Cell t = cells[x, y];
					t.Value = "";
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
					if (cells[x, y].Value == str) {
						occ++;
					}
				}
			}

			return occ;
		}

		private bool isSqrt(int val, int _sq) {
			var sq = (int)Math.Sqrt(_sq);
			int floor = (int)Math.Floor((float)((val + 1) / (sq + 1)));
			float nonfloor = ((float)(val + 1) / (sq + 1));

			if (floor == nonfloor) {
				return true;
			}
			return false;
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
					
					if (isSqrt(x, Width) == true || isSqrt(y, Height) == true) {
						possibilities[x, y] = 0;
					} else {
						if (GetCell(x, y).Value == "") {
							var column = GetColumn(y);
							var row = GetRow(x);
							var group = GetGroup(GetCell(x, y).Group);

							possibilities[x, y] = 1;

							for (int a = 0; a < column.Count; a++) {
								if (column[a].Value == num) {
									possibilities[x, y] = 0;
								}
							}

							for (int b = 0; b < row.Count; b++) {
								if (row[b].Value == num) {
									possibilities[x, y] = 0;
								}
							}

							for (int c = 0; c < group.Count; c++) {
								if (group[c].X != x && group[c].Y != y && group[c].Value == num) {
									possibilities[x, y] = 0;
								}
							}
						}
					}
				}
			}

			return ProcessPossibilities(possibilities);
		}

		private int[,] ProcessPossibilities(int[,] array) {
			for (int x = 0; x < array.GetLength(0); x++) {
				for (int y = 0; y < array.GetLength(1); y++) {
					if (array[x, y] == 1) {
						var group = GetGroup(GetCell(x, y).Group);
						var row = GetRow(x);
						var column = GetColumn(y);

						int[] dummy = { 0, 0, 0 };

						for (int i = 0; i < group.Count; i++) {
							if (array[group[i].X, group[i].Y] == 1 || array[group[i].X, group[i].Y] == -1) {
								dummy[0]++;
							}
						}

						for (int i = 0; i < row.Count; i++) {
							if (array[i, y] == 1 || array[i, y] == -1) {
								dummy[1]++;
							}
						}

						for (int _i = 0; _i < column.Count; _i++) {
							if (array[x, _i] == 1 || array[x, _i] == -1) {
								dummy[2]++;
							}
						}

						for (int i = 0; i < dummy.Length; i++) {
							if (dummy[i] == 1) {
								array[x, y] = -1;
								//Console.WriteLine("(" + x + "," + y + ") " + dummy[0] + dummy[1] + dummy[2]);
							}
						}
					}
				}
			}

			return array;

		}

	}
}
