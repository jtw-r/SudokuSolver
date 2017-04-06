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
			this.dataSet1 = new System.Data.DataSet();
			this.boardGrid = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "NewDataSet";
			// 
			// boardGrid
			// 
			this.boardGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.boardGrid.BackColor = System.Drawing.Color.White;
			this.boardGrid.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.boardGrid.ColumnCount = 1;
			this.boardGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.boardGrid.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.boardGrid.Location = new System.Drawing.Point(13, 13);
			this.boardGrid.Name = "boardGrid";
			this.boardGrid.RowCount = 1;
			this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.boardGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.boardGrid.Size = new System.Drawing.Size(36, 26);
			this.boardGrid.TabIndex = 0;
			this.boardGrid.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.boardGrid_CellPaint);
			this.boardGrid.BackColorChanged += new System.EventHandler(this.boardGrid_BackColorChanged);
			this.boardGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.boardGrid_Paint);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(286, 132);
			this.Controls.Add(this.boardGrid);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Data.DataSet dataSet1;

		public TableLayoutPanel boardGrid;

		public void resizeBoard(int _w, int _h) {
			int m = 2;
			boardGrid.Size = new System.Drawing.Size((((_w+m-1)*25)+15), (((_h+m-1)*25))+15);
			boardGrid.RowCount = _h + m;
			boardGrid.ColumnCount = _w + m;

			boardGrid.SuspendLayout();
			boardGrid.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;//.AddColumns;
			boardGrid.ColumnStyles.Clear();
			boardGrid.RowStyles.Clear();
			for (int a = 0; a < boardGrid.ColumnCount; a++) {
				ColumnStyle cs;
				if (a != 3 && a != 7 && a != 11) {
					cs = new ColumnStyle(SizeType.Absolute, (boardGrid.ColumnCount + 1) * 25 / boardGrid.ColumnCount);
				} else {
					cs = new ColumnStyle(SizeType.Absolute, 5);
				}
					
				boardGrid.ColumnStyles.Add(cs);
			}
			for (int b = 0; b < boardGrid.RowCount; b++) {
				RowStyle rs;
				if (b != 3 && b != 7 && b != 11) {
					rs = new RowStyle(SizeType.Absolute, (boardGrid.RowCount + 1) * 25 / boardGrid.RowCount);
				} else {
					rs = new RowStyle(SizeType.Absolute, 5);
				}
				boardGrid.RowStyles.Add(rs);
			}

			for (var x = 0; x < boardGrid.ColumnCount; x++) {
				for (var y = 0; y < boardGrid.RowCount; y++) {
					if ((x != 3 && x != 7 && x != 11) && (y != 3 && y != 7 && y != 11)) {
						TextField obj = program.gameBoard.GetTile(x,y).field = new TextField(x,y);
						obj.field.TextChanged += (sender, e) => TextChanged(sender, obj, e);
						boardGrid.Controls.Add(obj.field, x, y);
					} else {
						boardGrid.CellPaint += boardGrid_CellPaint;
					}
				}
			}

			boardGrid.ResumeLayout();
		}

		public void UpdateColorSquare(int _x, int _y, Color _color) {
			var obj = program.gameBoard.GetTile(_x, _y).field;
			obj.field.BackColor = _color;
			boardGrid.CellPaint += (sender, e) => CellPaint(sender, _x, _y, _color, e);
		}
	}
}

