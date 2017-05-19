using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SudokuSolver_Try1 {
	public class Tile {
		// Basic class for each tile in the UI grid.
		// Should only be used in UIBoard.cs
		
		public TextBox field;

		// Backing that the text box is attached to.
		// Mostly used for changing the colour of the cell.
		public Panel panel;

		public int X { get; }
		public int Y { get; }

		// Each board is seperated into groups,
		// each group is Sqrt(original width) by Sqrt(original height).
		// 9x9: Each group is 3x3 so 9 tiles. This is the same with Cell.cs
		// 1 2 3
		// 4 5 6
		// 7 8 9
		public int group { get; }

		public bool hasField { get; set; }

		public Tile(int _x, int _y, TextBox _field, Panel _panel, bool _hasField, int _w, int _h ) {
			this.X = _x;
			this.Y = _y;
			this.field = _field;
			this.panel = _panel;
			this.hasField = _hasField;

			var x_g = (int)((_x) / Math.Ceiling(Math.Sqrt(_w + 1)));
			var y_g = (int)((_y) / Math.Ceiling(Math.Sqrt(_h + 1)));

			this.group = (x_g * (int)Math.Sqrt(_w)) + (y_g);
		}

	}
}
