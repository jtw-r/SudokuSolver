using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver_Try1 {
	public partial class Form1 : Form {

		public Form1() {
			InitializeComponent();
		}

		private void boardGrid_Paint(object sender, PaintEventArgs e) {

		}

		private void boardGrid_CellPaint(object sender, TableLayoutCellPaintEventArgs e) {
			int x = e.Row;
			int y = e.Column;
			if ((x == 3 || x == 7 || x == 11) && (y == 3 || y == 7 || y == 11)) {
				e.Graphics.DrawRectangle(new Pen(Color.Blue), e.CellBounds);
			}
		}
	}
}
