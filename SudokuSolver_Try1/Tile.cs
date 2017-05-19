using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SudokuSolver_Try1 {
	public class Tile {
		private int x;
		private int y;
		
		public int group;
		public TextBox field;
		public Panel panel;
		public bool hasField = false;

		public int X {
			get {
				return x;
			}

			set {
				this.x = value;
			}
		}

		public int Y {
			get {
				return y;
			}

			set {
				this.y = value;
			}
		}

		public Tile(int _x, int _y, TextBox _field, Panel _panel, bool _hasField, int _w, int _h ) {
			this.x = _x;
			this.y = _y;
			this.field = _field;
			this.panel = _panel;
			this.hasField = _hasField;

			var x_g = (int)((_x) / Math.Ceiling(Math.Sqrt(_w + 1)));
			var y_g = (int)((_y) / Math.Ceiling(Math.Sqrt(_h + 1)));

			this.group = (x_g * (int)Math.Sqrt(_w)) + (y_g);
		}

	}
}
