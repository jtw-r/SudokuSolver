﻿using System.Windows.Forms;
using System;
using System.Drawing;
using System.Collections.Generic;

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
			this.highlightText = new System.Windows.Forms.TextBox();
			this.highlightTable = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_ClearHighlight = new System.Windows.Forms.Button();
			this.highlightTable.SuspendLayout();
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
			// highlightText
			// 
			this.highlightText.Location = new System.Drawing.Point(3, 3);
			this.highlightText.Name = "highlightText";
			this.highlightText.Size = new System.Drawing.Size(60, 20);
			this.highlightText.TabIndex = 1;
			this.highlightText.TextChanged += new System.EventHandler(this.highlightText_TextChanged);
			// 
			// highlightTable
			// 
			this.highlightTable.AutoSize = true;
			this.highlightTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.highlightTable.ColumnCount = 2;
			this.highlightTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.highlightTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.highlightTable.Controls.Add(this.highlightText, 0, 0);
			this.highlightTable.Controls.Add(this.label1, 1, 0);
			this.highlightTable.Controls.Add(this.btn_ClearHighlight, 0, 1);
			this.highlightTable.Location = new System.Drawing.Point(111, 85);
			this.highlightTable.Name = "highlightTable";
			this.highlightTable.RowCount = 2;
			this.highlightTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.highlightTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.highlightTable.Size = new System.Drawing.Size(160, 69);
			this.highlightTable.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(69, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Highlight Number";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_ClearHighlight
			// 
			this.btn_ClearHighlight.Location = new System.Drawing.Point(3, 29);
			this.btn_ClearHighlight.Name = "btn_ClearHighlight";
			this.btn_ClearHighlight.Size = new System.Drawing.Size(60, 37);
			this.btn_ClearHighlight.TabIndex = 3;
			this.btn_ClearHighlight.Text = "Clear Highlight";
			this.btn_ClearHighlight.UseVisualStyleBackColor = true;
			this.btn_ClearHighlight.Click += new System.EventHandler(this.btn_ClearHighlight_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(321, 263);
			this.Controls.Add(this.highlightTable);
			this.Controls.Add(this.boardGrid);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Padding = new System.Windows.Forms.Padding(12);
			this.Text = "Sudoku Solver";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.highlightTable.ResumeLayout(false);
			this.highlightTable.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public TableLayoutPanel boardGrid;

		public Board resizeBoard(int _w, int _h) {

			this.Controls.Add(this.boardGrid);
			int sq = (int)Math.Sqrt(_w);
			int m = sq-1;

			boardGrid.RowCount = _h + m;
			boardGrid.ColumnCount = _w + m;

			// Not sure if I need to flip these.
			Board gameBoard = new Board(boardGrid.RowCount, boardGrid.ColumnCount);

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
					/*//if ((x != 3 && x != 7 && x != 11) && (y != 3 && y != 7 && y != 11)) {
					int x_floor = (int)Math.Floor((float)(x + 1) / (sq+1));
					float x_nonfloor = ((float)(x + 1) / (sq+1));

					int y_floor = (int)(Math.Floor((float)(y + 1) / (sq+1)));
					float y_nonfloor = ((float)(y + 1) / (sq+1));
					if ((x_floor != x_nonfloor) && (y_floor != y_nonfloor)) {
						TextField obj = gameBoard.GetTile(x, y).field = new TextField(x, y);
						obj.field.TextChanged += (sender, e) => TextChanged(sender, obj, e);
						boardGrid.Controls.Add(obj.field, x, y);
					} else {
					}*/
					Tile obj = gameBoard.tiles[x,y];
					obj.panel = new Panel();
					boardGrid.Controls.Add(obj.panel);
					obj.panel.Margin = new Padding(0);
					obj.panel.Padding = new Padding(5);

					//Console.WriteLine(obj.panel.Size);

					int x_floor = (int)Math.Floor((float)(x + 1) / (sq + 1));
					float x_nonfloor = ((float)(x + 1) / (sq + 1));

					int y_floor = (int)(Math.Floor((float)(y + 1) / (sq + 1)));
					float y_nonfloor = ((float)(y + 1) / (sq + 1));
					if ((x_floor != x_nonfloor) && (y_floor != y_nonfloor)) {
						obj.panel.Size = new Size((boardGrid.RowCount + 1) * 25 / boardGrid.RowCount, (boardGrid.RowCount + 1) * 25 / boardGrid.RowCount);
						//obj.panel.Margin = new Padding(5, 5, 5, 5);
						obj.field = new TextBox() { AutoSize = false, TextAlign = HorizontalAlignment.Center, BorderStyle = BorderStyle.None };
						obj.panel.Controls.Add(obj.field);
						obj.field.Location = new Point(obj.panel.Padding.Left,obj.panel.Padding.Top);
						obj.field.Width = obj.panel.Width-obj.panel.Padding.Horizontal;
						obj.field.Height = obj.panel.Width-obj.panel.Padding.Vertical;
						obj.hasField = true;
						obj.field.TextChanged += (sender, e) => TextChanged(sender, obj, e);
						obj.panel.BackColor = Color.White;
						//obj.field.BackColor = Color.Green;
					} else {
						obj.panel.BackColor = Color.Black;
						Console.WriteLine("Black [" + x + "," + y + "]");
					}
				}
			}

			

			boardGrid.ResumeLayout();

			highlightTable.Location = new Point(boardGrid.Size.Width+Padding.Left*2, 5+Padding.Top);

			return gameBoard;

		}

		public void UpdateColorSquare(int _x, int _y, Color _color, bool thing = false) {
			Tile obj = program.gameBoard.tiles[_x,_y];
			obj.field.BackColor = _color;
			obj.panel.BackColor = _color;
		}

		public void CreateHighlight(string num) {
			RemoveHighlight();
			for (int x = 0; x < program.gameBoard.width; x++) {
				for (int y = 0; y < program.gameBoard.height; y++) {
					if (program.gameBoard.tiles[x,y].value == num && num != "") {
						UpdateColorSquare(x, y, Color.Yellow, true);
					}
				}
			}
		}

		public void RemoveHighlight() {
			for (int x = 0; x < program.gameBoard.width; x++) {
				for (int y = 0; y < program.gameBoard.height; y++) {
					if (program.gameBoard.GetTile(x, y).hasField) {
						if (program.gameBoard.tiles[x, y].field.BackColor != Color.White) {
							UpdateColorSquare(x, y, Color.White, true);
						}
					}
				}
			}
		}

		private TextBox highlightText;
		private TableLayoutPanel highlightTable;
		private Label label1;
		private Button btn_ClearHighlight;
	}
}

