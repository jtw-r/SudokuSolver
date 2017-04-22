using System;
using System.Collections.Generic;
using System.Drawing;
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
			Console.WriteLine(_x);
			if (e.Column == _x && e.Row == _y) {
				//e.Graphics.DrawRectangle(new Pen(Color.Black, 4f), e.CellBounds);
				e.Graphics.FillRectangle(new SolidBrush(_color), e.CellBounds);
			}
		}

		private void boardGrid_BackColorChanged(object sender, EventArgs e) {
			//CellPaint(sender, 0, 0, e);
		}

		private new void TextChanged(object sender, Tile obj, EventArgs e) {
			program.gameBoard.tiles[obj.x, obj.y].value = obj.field.Text;
			CreateHighlight(highlightText.Text);
			ShowPossibilities(highlightText.Text);
			SetCount();
		}

		private void textBox1_BackColorChanged(object sender, EventArgs e) {

		}

		private void Form1_Load(object sender, EventArgs e) {

		}

		private void btn_ClearHighlight_Click(object sender, EventArgs e) {
			
		}

		private void btn_ShowHighlight_Click(object sender, EventArgs e) {
			//CreateHighlight(highlightText.Text);
		}

		private void btn_ShowHighlight_MouseUp(object sender, MouseEventArgs e) {
			CreateHighlight(highlightText.Text);
		}

		private void highlightText_TextChanged(object sender, EventArgs e) {
			CreateHighlight(highlightText.Text);
			ShowPossibilities(highlightText.Text);
			SetCount();

		}

		private void highlight_Click(object sender, Tile obj, EventArgs e) {
			rcHighlight(obj);
		}

		public void rcHighlight(Tile obj) {
			if (clickHighlight.Checked) {
				RemoveHighlight(Color.LightBlue, true);
				RemoveHighlight(Color.Blue, true);

				List<Tile> col = program.gameBoard.GetColumn(obj.y);
				List<Tile> row = program.gameBoard.GetRow(obj.x);

				for (int col_num = 0; col_num < col.Count; col_num++) {
					if (col[col_num].hasField) {
						if (col[col_num].panel.BackColor == Color.White) {
							if (col[col_num].x != obj.x) {
								col[col_num].panel.BackColor = Color.LightBlue;
								col[col_num].field.BackColor = Color.LightBlue;
							} else {
								col[col_num].panel.BackColor = Color.Blue;
								col[col_num].field.BackColor = Color.Blue;
							}
						}
					}
				}

				for (int row_num = 0; row_num < row.Count; row_num++) {
					if (row[row_num].hasField) {
						if (row[row_num].panel.BackColor == Color.White) {
							if (row[row_num].y != obj.y) {
								row[row_num].panel.BackColor = Color.LightBlue;
								row[row_num].field.BackColor = Color.LightBlue;
							} else {
								row[row_num].panel.BackColor = Color.Blue;
								row[row_num].field.BackColor = Color.Blue;
							}
						}
					}
				}

				program.lastExec = obj;
			}
		}

		/*private void clickHighlight_Click(object sender, EventArgs e) {
			if (!clickHighlight.Checked) {
				RemoveHighlight(Color.LightBlue, true);
				RemoveHighlight(Color.Blue, true);
			}
		}*/

		private void btn_ClearGrid_MouseUp(object sender, MouseEventArgs e) {
			program.gameBoard.Clear();
		}

		private void btn_LoadPreset_MouseUp(object sender, MouseEventArgs e) {
			int n;
			if (tb_presetNum.Text == "") {
				return;
			} else if (int.TryParse(tb_presetNum.Text,out n)) {
				program.gameBoard.LoadDataset(Convert.ToInt32(tb_presetNum.Text)-1);
			}
			
		}

		private void btn_autoCycle_MouseUp(object sender, MouseEventArgs e) {
			Cycle();
		}

		private void focusHighlight_CheckedChanged(object sender, EventArgs e) {
			if (focusHighlight.Checked) {
				CreateHighlight(highlightText.Text);
			} else {
				RemoveHighlight(Color.Yellow, true);
				if (program.lastExec != null && clickHighlight.Checked) {
					rcHighlight(program.lastExec);
				}
			}
		}

		private void clickHighlight_Click_1(object sender, EventArgs e) {
		}

		private void cb_possib_CheckedChanged(object sender, EventArgs e) {
			if (cb_possib.Checked) {
				ShowPossibilities(highlightText.Text);
			} else {
				RemoveHighlight(Color.LightGreen, true);
				RemoveHighlight(Color.Green, true);
			}
		}

		private void clickHighlight_CheckedChanged(object sender, EventArgs e) {
			if(!clickHighlight.Checked) {
				RemoveHighlight(Color.LightBlue, true);
				RemoveHighlight(Color.Blue, true);
			} else {
				if (program.lastExec != null) {
					rcHighlight(program.lastExec);
				}
			}
		}

		private void btn_ClearHighlight_MouseUp(object sender, MouseEventArgs e) {
			highlightText.Text = "";
			RemoveHighlight(Color.Yellow, true);
			if (program.lastExec != null) {
				rcHighlight(program.lastExec);
			}

			cb_possib.Checked = false;
			focusHighlight.Checked = false;
		}
	}
}
