using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver_Try1 {
	public class TextField {
		public int x;
		public int y;
		public TextBox field;

		public TextField(int _x, int _y) {
			this.field = new TextBox() { AutoSize = true, TextAlign = HorizontalAlignment.Center, BorderStyle = BorderStyle.None };
			this.x = _x;
			this.y = _y;
		}

	}
}
