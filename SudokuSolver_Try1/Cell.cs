using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver_Try1 {
	public class Cell {
		private int x;
		private int y;
		private string value;
		private int group;

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

		public string Value {
			get {
				return value;
			}

			set {
				this.value = value;
			}
		}

		public int Group {
			get {
				return group;
			}
		}

		public Cell(int _x, int _y, int _w, int _h, string _value = "") {
			this.x = _x;
			this.y = _y;
			this.value = _value;

			var x_g = (int)((_x) / Math.Ceiling(Math.Sqrt(_h + 1)));
			var y_g = (int)((_y) / Math.Ceiling(Math.Sqrt(_w + 1)));

			this.group = (x_g * (int)Math.Sqrt(_h)) + (y_g);

		}

	}
}
