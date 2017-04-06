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

		public Program program;

		public Form1() {
			InitializeComponent();
		}

		private void boardGrid_Paint(object sender, PaintEventArgs e) {

		}

		public void boardGrid_CellPaint(object sender, int sq, TableLayoutCellPaintEventArgs e) {
			int x = e.Column;
			int y = e.Row;
			int x_floor = (int)Math.Floor((float)(x + 1) / (sq + 1));
			float x_nonfloor = ((float)(x + 1) / (sq + 1));

			int y_floor = (int)(Math.Floor((float)(y + 1) / (sq + 1)));
			float y_nonfloor = ((float)(y + 1) / (sq + 1));
			if ((x_floor == x_nonfloor) || (y_floor == y_nonfloor)) {
				//e.Graphics.DrawRectangle(new Pen(Color.Black, 4f), e.CellBounds);
				e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
			}
		}
		public void CellPaint(object sender, int _x, int _y, Color _color, TableLayoutCellPaintEventArgs e) {
			if( e.Column == _x && e.Row == _y) {
				//e.Graphics.DrawRectangle(new Pen(Color.Black, 4f), e.CellBounds);
				e.Graphics.FillRectangle(new SolidBrush(_color), e.CellBounds);
			}
		}

		private void boardGrid_BackColorChanged(object sender, EventArgs e) {
			
		}

		private void TextChanged(object sender, TextField obj, EventArgs e) {
			program.gameBoard.GetTile(obj.x,obj.y).value = obj.field.Text;
			//Console.WriteLine("["+obj.x+","+obj.y+"] "+program.gameBoard.GetTile(obj.x, obj.y).value);
		}

		private void textBox1_BackColorChanged(object sender, EventArgs e) {

		}

		private void Form1_Load(object sender, EventArgs e) {

		}
	}
}
