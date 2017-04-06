using System.Windows.Forms;
using System;
using System.Drawing;

namespace SudokuSolver_Try1 {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.boardGrid = new System.Windows.Forms.TableLayoutPanel();
			this.SuspendLayout();
			// 
			// boardGrid
			// 
			this.boardGrid.AutoSize = true;
			this.boardGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.boardGrid.BackColor = System.Drawing.Color.White;
			this.boardGrid.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.boardGrid.ColumnCount = 1;
			this.boardGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.boardGrid.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.boardGrid.Location = new System.Drawing.Point(15, 15);
			this.boardGrid.Name = "boardGrid";
			this.boardGrid.RowCount = 1;
			this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.boardGrid.Size = new System.Drawing.Size(2, 2);
			this.boardGrid.TabIndex = 0;
			this.boardGrid.BackColorChanged += new System.EventHandler(this.boardGrid_BackColorChanged);
			this.boardGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.boardGrid_Paint);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(137, 71);
			this.Controls.Add(this.boardGrid);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Padding = new System.Windows.Forms.Padding(12);
			this.Text = "Sudoku Solver";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public TableLayoutPanel boardGrid;

		public void resizeBoard(int _w, int _h) {
			int sq = (int)Math.Sqrt(_w);
			int m = sq-1;

			boardGrid.RowCount = _h + m;
			boardGrid.ColumnCount = _w + m;

			boardGrid.SuspendLayout();
			boardGrid.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;//.AddColumns;
			boardGrid.ColumnStyles.Clear();
			boardGrid.RowStyles.Clear();
			for (int a = 0; a < boardGrid.ColumnCount; a++) {
				ColumnStyle cs;
				//if (((float)(a) / sq+1) != ((a) / sq+1)) {
				int floor = (int)Math.Floor((float)((a+1)/(sq+1)));
				float nonfloor = ((float)(a+1)/(sq+1));
				if (floor != nonfloor) {
					cs = new ColumnStyle(SizeType.Absolute, (boardGrid.ColumnCount + 1) * 25 / boardGrid.ColumnCount);
				} else {
					cs = new ColumnStyle(SizeType.Absolute, 5);
				}
					
				boardGrid.ColumnStyles.Add(cs);
			}
			for (int b = 0; b < boardGrid.RowCount; b++) {
				RowStyle rs;
				//if (((float)(b) / sq+1) != ((b) / sq+1)) {
				int floor = (int)Math.Floor((float)((b + 1) / (sq + 1)));
				float nonfloor = ((float)(b + 1) / (sq + 1));
				if (floor != nonfloor) {
					rs = new RowStyle(SizeType.Absolute, (boardGrid.RowCount + 1) * 25 / boardGrid.RowCount);
				} else {
					rs = new RowStyle(SizeType.Absolute, 5);
				}
				boardGrid.RowStyles.Add(rs);
			}

			for (var x = 0; x < boardGrid.ColumnCount; x++) {
				for (var y = 0; y < boardGrid.RowCount; y++) {
					//if ((x != 3 && x != 7 && x != 11) && (y != 3 && y != 7 && y != 11)) {
					int x_floor = (int)Math.Floor((float)(x + 1) / (sq+1));
					float x_nonfloor = ((float)(x + 1) / (sq+1));

					int y_floor = (int)(Math.Floor((float)(y + 1) / (sq+1)));
					float y_nonfloor = ((float)(y + 1) / (sq+1));
					if ((x_floor != x_nonfloor) && (y_floor != y_nonfloor)) {
						TextField obj = program.gameBoard.GetTile(x, y).field = new TextField(x, y);
						obj.field.TextChanged += (sender, e) => TextChanged(sender, obj, e);
						boardGrid.Controls.Add(obj.field, x, y);
					} else {
					}
				}
			}

			boardGrid.CellPaint += (sender, e) => boardGrid_CellPaint(sender, sq, e);

			boardGrid.ResumeLayout();
		}

		public void UpdateColorSquare(int _x, int _y, Color _color) {
			var obj = program.gameBoard.GetTile(_x, _y).field;
			obj.field.BackColor = _color;
			if ((Math.Floor((float)(_x + 1) / 4) == ((float)(_x + 1) / 4)) || (Math.Floor((float)(_y + 1) / 4) == ((float)(_y + 1) / 4))) {
				boardGrid.CellPaint += (sender, e) => CellPaint(sender, 0, 0, _color, e);
			} else {
				boardGrid.CellPaint += (sender, e) => CellPaint(sender, _x, _y, _color, e);
			}
		}
	}
}

