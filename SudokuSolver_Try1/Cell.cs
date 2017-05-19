using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver_Try1 {
	public class Cell {
		// Basic class for each cell in the data array.
		// Used in DataBoard.cs

		public int X { get; }
		public int Y { get; }

		public string Value { get; set; }

		// See Tile.cs for a detailed explanation.
		public int Group { get; }

		public Cell(int _x, int _y, int _w, int _h, string _value = "") {
			this.X = _x;
			this.Y = _y;
			this.Value = _value;

			var x_g = (int)((_x) / Math.Ceiling(Math.Sqrt(_h + 1)));
			var y_g = (int)((_y) / Math.Ceiling(Math.Sqrt(_w + 1)));

			this.Group = (x_g * (int)Math.Sqrt(_h)) + (y_g);

		}

	}
}
