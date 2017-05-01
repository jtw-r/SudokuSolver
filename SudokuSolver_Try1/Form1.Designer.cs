using System.Windows.Forms;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

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
			this.highlightText = new System.Windows.Forms.TextBox();
			this.highlightTable = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lb_occur = new System.Windows.Forms.Label();
			this.btn_autoCycle = new System.Windows.Forms.Button();
			this.btn_ClearGrid = new System.Windows.Forms.Button();
			this.cb_possib = new System.Windows.Forms.CheckBox();
			this.focusHighlight = new System.Windows.Forms.CheckBox();
			this.clickHighlight = new System.Windows.Forms.CheckBox();
			this.btn_LoadPreset = new System.Windows.Forms.Button();
			this.cb_autoFill = new System.Windows.Forms.CheckBox();
			this.btn_ClearHighlight = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.highlightTable.SuspendLayout();
			this.SuspendLayout();
			// 
			// highlightText
			// 
			this.highlightText.Location = new System.Drawing.Point(118, 3);
			this.highlightText.Name = "highlightText";
			this.highlightText.Size = new System.Drawing.Size(115, 20);
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
			this.highlightTable.Controls.Add(this.highlightText, 1, 0);
			this.highlightTable.Controls.Add(this.label1, 0, 0);
			this.highlightTable.Controls.Add(this.label2, 0, 1);
			this.highlightTable.Controls.Add(this.lb_occur, 1, 1);
			this.highlightTable.Controls.Add(this.btn_autoCycle, 0, 10);
			this.highlightTable.Controls.Add(this.btn_ClearGrid, 0, 7);
			this.highlightTable.Controls.Add(this.cb_possib, 0, 5);
			this.highlightTable.Controls.Add(this.focusHighlight, 0, 4);
			this.highlightTable.Controls.Add(this.clickHighlight, 0, 3);
			this.highlightTable.Controls.Add(this.cb_autoFill, 1, 5);
			this.highlightTable.Controls.Add(this.btn_ClearHighlight, 1, 4);
			this.highlightTable.Controls.Add(this.btn_LoadPreset, 1, 7);
			this.highlightTable.Controls.Add(this.button1, 1, 8);
			this.highlightTable.Location = new System.Drawing.Point(34, 15);
			this.highlightTable.Name = "highlightTable";
			this.highlightTable.RowCount = 11;
			this.highlightTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.highlightTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.highlightTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.highlightTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.highlightTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.highlightTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.highlightTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.highlightTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.highlightTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.highlightTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.highlightTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.highlightTable.Size = new System.Drawing.Size(236, 275);
			this.highlightTable.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 26);
			this.label1.TabIndex = 2;
			this.label1.Text = "Focus Number:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Occurances:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lb_occur
			// 
			this.lb_occur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_occur.AutoSize = true;
			this.lb_occur.Location = new System.Drawing.Point(118, 26);
			this.lb_occur.Name = "lb_occur";
			this.lb_occur.Size = new System.Drawing.Size(115, 13);
			this.lb_occur.TabIndex = 6;
			this.lb_occur.Text = "0";
			this.lb_occur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_autoCycle
			// 
			this.btn_autoCycle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.highlightTable.SetColumnSpan(this.btn_autoCycle, 2);
			this.btn_autoCycle.Location = new System.Drawing.Point(3, 232);
			this.btn_autoCycle.Name = "btn_autoCycle";
			this.btn_autoCycle.Size = new System.Drawing.Size(230, 40);
			this.btn_autoCycle.TabIndex = 11;
			this.btn_autoCycle.Text = "Solve";
			this.btn_autoCycle.UseVisualStyleBackColor = true;
			this.btn_autoCycle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_autoCycle_MouseUp);
			// 
			// btn_ClearGrid
			// 
			this.btn_ClearGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_ClearGrid.Location = new System.Drawing.Point(3, 150);
			this.btn_ClearGrid.Name = "btn_ClearGrid";
			this.highlightTable.SetRowSpan(this.btn_ClearGrid, 2);
			this.btn_ClearGrid.Size = new System.Drawing.Size(109, 66);
			this.btn_ClearGrid.TabIndex = 7;
			this.btn_ClearGrid.Text = "Clear Board";
			this.btn_ClearGrid.UseVisualStyleBackColor = true;
			this.btn_ClearGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_ClearGrid_MouseUp);
			// 
			// cb_possib
			// 
			this.cb_possib.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cb_possib.AutoSize = true;
			this.cb_possib.Location = new System.Drawing.Point(3, 111);
			this.cb_possib.Name = "cb_possib";
			this.cb_possib.Size = new System.Drawing.Size(109, 23);
			this.cb_possib.TabIndex = 13;
			this.cb_possib.Text = "Show Possibilities";
			this.cb_possib.UseVisualStyleBackColor = true;
			this.cb_possib.CheckedChanged += new System.EventHandler(this.cb_possib_CheckedChanged);
			// 
			// focusHighlight
			// 
			this.focusHighlight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.focusHighlight.AutoSize = true;
			this.focusHighlight.Location = new System.Drawing.Point(3, 75);
			this.focusHighlight.Name = "focusHighlight";
			this.focusHighlight.Size = new System.Drawing.Size(109, 30);
			this.focusHighlight.TabIndex = 12;
			this.focusHighlight.Text = "Focus Highlight";
			this.focusHighlight.UseVisualStyleBackColor = true;
			this.focusHighlight.CheckedChanged += new System.EventHandler(this.focusHighlight_CheckedChanged);
			// 
			// clickHighlight
			// 
			this.clickHighlight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.clickHighlight.AutoSize = true;
			this.clickHighlight.Checked = true;
			this.clickHighlight.CheckState = System.Windows.Forms.CheckState.Checked;
			this.clickHighlight.Location = new System.Drawing.Point(3, 52);
			this.clickHighlight.Name = "clickHighlight";
			this.clickHighlight.Size = new System.Drawing.Size(109, 17);
			this.clickHighlight.TabIndex = 4;
			this.clickHighlight.Text = "Click Highlight";
			this.clickHighlight.UseVisualStyleBackColor = true;
			this.clickHighlight.CheckedChanged += new System.EventHandler(this.clickHighlight_CheckedChanged);
			// 
			// btn_LoadPreset
			// 
			this.btn_LoadPreset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_LoadPreset.Location = new System.Drawing.Point(118, 150);
			this.btn_LoadPreset.Name = "btn_LoadPreset";
			this.btn_LoadPreset.Size = new System.Drawing.Size(115, 30);
			this.btn_LoadPreset.TabIndex = 8;
			this.btn_LoadPreset.Text = "Load Board";
			this.btn_LoadPreset.UseVisualStyleBackColor = true;
			this.btn_LoadPreset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_LoadPreset_MouseUp);
			// 
			// cb_autoFill
			// 
			this.cb_autoFill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cb_autoFill.Location = new System.Drawing.Point(118, 111);
			this.cb_autoFill.Name = "cb_autoFill";
			this.cb_autoFill.Size = new System.Drawing.Size(115, 23);
			this.cb_autoFill.TabIndex = 10;
			this.cb_autoFill.Text = "Autofill Possibilities";
			this.cb_autoFill.UseVisualStyleBackColor = true;
			this.cb_autoFill.CheckedChanged += new System.EventHandler(this.cb_autoFill_CheckedChanged);
			// 
			// btn_ClearHighlight
			// 
			this.btn_ClearHighlight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_ClearHighlight.Location = new System.Drawing.Point(118, 75);
			this.btn_ClearHighlight.Name = "btn_ClearHighlight";
			this.btn_ClearHighlight.Size = new System.Drawing.Size(115, 30);
			this.btn_ClearHighlight.TabIndex = 3;
			this.btn_ClearHighlight.Text = "Clear Highlight";
			this.btn_ClearHighlight.UseVisualStyleBackColor = true;
			this.btn_ClearHighlight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_ClearHighlight_MouseUp);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(118, 186);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 30);
			this.button1.TabIndex = 14;
			this.button1.Text = "Save Board";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(321, 385);
			this.Controls.Add(this.highlightTable);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Padding = new System.Windows.Forms.Padding(12);
			this.ShowIcon = false;
			this.Text = "Sudoku Solver";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.highlightTable.ResumeLayout(false);
			this.highlightTable.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public Board resizeBoard(int _w, int _h) {

			var d = this.Controls.Find("boardGrid",false);
			if (d.Length > 0) {
				d[0].Dispose();
			}

			TableLayoutPanel boardGrid = new TableLayoutPanel();
			boardGrid.Name = "boardGrid";
			boardGrid.Location = new Point(12, 12);
			boardGrid.AutoSize = AutoSize;
			boardGrid.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

			this.Controls.Add(boardGrid);
			int w_sq = (int)Math.Sqrt(_w);
			int h_sq = (int)Math.Sqrt(_h);

			boardGrid.ColumnCount = _w + (w_sq - 1);
			boardGrid.RowCount = _h + (h_sq - 1);

			Board gameBoard = new Board(boardGrid.ColumnCount, boardGrid.RowCount);

			boardGrid.SuspendLayout();
			boardGrid.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
			boardGrid.ColumnStyles.Clear();
			boardGrid.RowStyles.Clear();

			for (var x = 0; x < gameBoard.Width; x++) {
				for (var y = 0; y < gameBoard.Height; y++) {
					Tile obj = gameBoard.GetTile(x, y);

					obj.panel = new Panel() {
						Margin = new Padding(0),
						Padding = new Padding(5),
						BackColor = Color.White,
						Size = new Size(
							(boardGrid.ColumnCount + 1) * 25 / boardGrid.ColumnCount,
							(boardGrid.RowCount + 1) * 25 / boardGrid.RowCount)
					};

					boardGrid.Controls.Add(obj.panel);

					if (!isSqrt(x, h_sq) && !isSqrt(y, w_sq)) {
						obj.field = new TextBox() {
							AutoSize = false,
							TextAlign = HorizontalAlignment.Center,
							BorderStyle = BorderStyle.None,
							Location = new Point(obj.panel.Padding.Left, obj.panel.Padding.Top),
							Size = new Size(
								obj.panel.Width - obj.panel.Padding.Horizontal,
								obj.panel.Width - obj.panel.Padding.Vertical)
						};

						obj.panel.Controls.Add(obj.field);

						obj.field.TextChanged += (sender, e) => TextChanged(sender, obj, e);
						obj.field.Click += (sender, e) => highlight_Click(sender, obj, e);

						obj.hasField = true;
					}
				}
			}

			for (int a = 0; a < boardGrid.ColumnCount; a++) {
				ColumnStyle cs;

				if (!isSqrt(a, w_sq)) {
					cs = new ColumnStyle(SizeType.Absolute, (boardGrid.ColumnCount + 1) * 25 / boardGrid.ColumnCount);
				} else {
					cs = new ColumnStyle(SizeType.Absolute, 5);
					var col = gameBoard.GetColumn(a);

					for (int _x = 0; _x < col.Count; _x++) {
						col[_x].panel.BackColor = Color.Black;
					}

				}

				boardGrid.ColumnStyles.Add(cs);
			}

			for (int b = 0; b < boardGrid.RowCount; b++) {
				RowStyle rs;

				if (!isSqrt(b, h_sq)) {
					rs = new RowStyle(SizeType.Absolute, (boardGrid.RowCount + 1) * 25 / boardGrid.RowCount);
				} else {
					rs = new RowStyle(SizeType.Absolute, 5);
					var row = gameBoard.GetRow(b);

					for (int _y = 0; _y < row.Count; _y++) {
						row[_y].panel.BackColor = Color.Black;
					}
				}
				boardGrid.RowStyles.Add(rs);
			}

			boardGrid.ResumeLayout();

			highlightTable.Location = new Point(boardGrid.Size.Width + Padding.Left * 2, 5 + Padding.Top);

			return gameBoard;

		}

		public void UpdateColorSquare(int _x, int _y, Color _color, bool thing = false) {
			Tile obj = program.gameBoard.GetTile(_x, _y);
			if (obj.hasField) {
				obj.field.BackColor = _color;
			}
			obj.panel.BackColor = _color;
		}

		public void CreateHighlight(string num) {
			if (focusHighlight.Checked) {
				RemoveHighlight(Color.Yellow, true);
				for (int x = 0; x < program.gameBoard.Width; x++) {
					for (int y = 0; y < program.gameBoard.Height; y++) {
						if (program.gameBoard.GetTile(x, y).value == num && num != "") {
							UpdateColorSquare(x, y, Color.Yellow, true);
						}
					}
				}
			}
		}

		public void RemoveHighlight(Color _color, bool other = false) {
			for (int x = 0; x < program.gameBoard.Width; x++) {
				for (int y = 0; y < program.gameBoard.Height; y++) {
					if (program.gameBoard.GetTile(x, y).hasField) {
						if (other) {
							if (program.gameBoard.GetTile(x, y).field.BackColor == _color) {
								UpdateColorSquare(x, y, Color.White, true);
							}
						} else {
							if (program.gameBoard.GetTile(x, y).field.BackColor != _color) {
								UpdateColorSquare(x, y, Color.White, true);
							}
						}
					}
				}
			}
		}

		public bool isSqrt(int val, int sq) {
			int floor = (int)Math.Floor((float)((val + 1) / (sq + 1)));
			float nonfloor = ((float)(val + 1) / (sq + 1));

			if (floor == nonfloor) {
				return true;
			}
			return false;
		}

		public int cycleNum = 0;

		public int[,] GetPossibilities(string num) {
			Board gb = program.gameBoard;

			int[,] poss = new int[program.gameBoard.Width, program.gameBoard.Height];

			for (int x = 0; x < program.gameBoard.Width; x++) {
				for (int y = 0; y < program.gameBoard.Height; y++) {

					if (program.gameBoard.GetTile(x, y).value == "" && program.gameBoard.GetTile(x, y).hasField) {
						var col = program.gameBoard.GetColumn(y);
						var row = program.gameBoard.GetRow(x);
						var group = program.gameBoard.GetGroup(program.gameBoard.GetTile(x, y).group);

						poss[x, y] = 1;

						for (int a = 0; a < col.Count; a++) {
							if (col[a].value == num) {
								poss[x, y] = 0;
							}
						}

						for (int b = 0; b < row.Count; b++) {
							if (row[b].value == num) {
								poss[x, y] = 0;
							}
						}

						for (int c = 0; c < group.Count; c++) {
							if (group[c].x != x && group[c].y != y && group[c].value == num) {
								poss[x, y] = 0;
							}
						}
					}
				}
			}

			return poss;
		}

		public void ShowPossibilities(string pos, bool thing = false, int mode = 0) {
			if (cb_possib.Checked || thing) {
				RemoveHighlight(Color.LightGreen, true);
				RemoveHighlight(Color.Green, true);
				var gb = program.gameBoard;

				int[,] poss = GetPossibilities(pos);

				for (int x = 0; x < program.gameBoard.Width; x++) {
					for (int y = 0; y < program.gameBoard.Height; y++) {

						if (poss[x, y] == 1) {
							if (!thing) {
								UpdateColorSquare(x, y, Color.LightGreen);
							}
						}

					}
				}

				for (int x = 0; x < program.gameBoard.Width; x++) {
					for (int y = 0; y < program.gameBoard.Height; y++) {
						if (poss[x, y] == 1) {
							var group = program.gameBoard.GetGroup(program.gameBoard.GetTile(x, y).group);
							var row = program.gameBoard.GetRow(x);
							var column = program.gameBoard.GetColumn(y);

							int[] dummy = { 0, 0, 0 };

							for (int i = 0; i < group.Count; i++) {
								if (poss[group[i].x, group[i].y] == 1) {
									dummy[0]++;
								}
							}

							for (int i = 0; i < row.Count; i++) {
								if (poss[i, y] == 1) {
									dummy[1]++;
								}
							}

							for (int i = 0; i < column.Count; i++) {
								if (poss[x, i] == 1) {
									dummy[2]++;
								}
							}

							for (int i = 0; i < dummy.Length; i++) {
								if (dummy[i] == 1) {
									if (cb_autoFill.Checked || thing) {
										program.gameBoard.GetTile(x, y).field.Text = "" + pos;
									} else {
										UpdateColorSquare(x, y, Color.Green);
									}
								}
							}
						}
					}
				}
			}
		}

		public void MasterCycle() {
			int tollerance = 10;
			// Do cycles of checking for possibilities.
			// If it gets stuck:
			//	Start a random guess, see it through, and if it doesn't work, re-guess.

			// Numbers that are not fully solved yet.
			List<int> left = new List<int>();

			// The history of what has happened.
			List<int> history = new List<int>();

			// At the start, add all values to left.
			for (int i = 1; i < 10; i++) {
				left.Add(i);
			}

			var gb = program.gameBoard;
			while (program.gameBoard.FindOccurance("") != 0) {
				// Loop this until the puzzle is solved.

				List<int> _left = new List<int>();
				history.Add(program.gameBoard.FindOccurance(""));

				foreach (var item in left) {
					// Basic check for possibilities.
					ShowPossibilities("" + item, true);

					// Add the numbers that still need to be solved
					// to a place holder list.
					if (program.gameBoard.FindOccurance("" + item) < 9) {
						_left.Add(item);
					}
				}

				// After everything is done set the main list to be
				// the place holder.
				left = _left;

				if (program.gameBoard.FindOccurance("") == 0) {
					// The gameboard is full! It solved it.
					return;
				} else if (history.Count > tollerance) {
					// Test if nothing has happened in '10' cycles.
					if (history[history.Count - (tollerance + 1)] == history[history.Count - 1]) {
						// By this point, the program has gotten stuck so it needs some help.
						// Create a restore point incase the random guess doesn't work and
						// finally, do a random guess to see if it will work.

						string[,] restorePoint = new string[program.gameBoard.Width, program.gameBoard.Height];

						for (int _x = 0; _x < program.gameBoard.Width; _x++) {
							for (int _y = 0; _y < program.gameBoard.Height; _y++) {
								if (program.gameBoard.GetTile(_x, _y).hasField) {
									restorePoint[_x, _y] = program.gameBoard.GetTile(_x, _y).field.Text.ToString();
								} else {
									restorePoint[_x, _y] = null;
								}
							}
						}

						// Find the number with the least possible spaces left.
						List<string> toSort = new List<string>();
						for (int i = 1; i < 10; i++) {
							if (program.gameBoard.FindOccurance(""+i) < 9) {
								toSort.Add(9-program.gameBoard.FindOccurance(""+i) + "," + i);
							}
						}

						toSort.Sort();
						string[] num = toSort[0].Split(',');

						if (GuessCycle(Convert.ToInt32(num[0]))) {
							// Yay! The random guess worked and the program was able to
							// completly solve the sudoku puzzle. Exit the while loop.
							return;
						} else {
							// Oh no. The random guess did not work. Reset the board to before
							// the random guess and try again.
							for (int _x = 0; _x < program.gameBoard.Width; _x++) {
								for (int _y = 0; _y < program.gameBoard.Height; _y++) {
									if (program.gameBoard.GetTile(_x, _y).hasField) {
										program.gameBoard.GetTile(_x, _y).field.Text = restorePoint[_x, _y].ToString();
									}
								}
							}
						}
					}
				}
			}
		}

		public bool GuessCycle(int num,int tollerance = 10) {
			var gb = program.gameBoard;
			int[,] poss = GetPossibilities("" + num);
			Random rnd = new Random();
			while (true) {
				int x = rnd.Next(1, 9);
				int y = rnd.Next(1, 9);

				if (poss[x, y] == 1) {
					program.gameBoard.GetTile(x, y).field.Text = "" + num;
					break;
				}
			}

			List<int> left = new List<int>();
			List<int> history = new List<int>();
			for (int i = 1; i < 10; i++) {
				left.Add(i);
			}

			while (program.gameBoard.FindOccurance("") != 0) {

				List<int> _left = new List<int>();
				history.Add(program.gameBoard.FindOccurance(""));

				foreach (var item in left) {
					// Basic check for possibilities.
					ShowPossibilities("" + item, true);

					if (program.gameBoard.FindOccurance("" + item) < 9) {
						_left.Add(item);
					}
				}

				left = _left;

				if (program.gameBoard.FindOccurance("") == 0) {
					return true;
				} else if (history.Count > tollerance) {
					if (history[history.Count - (tollerance + 1)] == history[history.Count - 1]) {
						bool canBreak = true;
						for (int i = history[history.Count - (tollerance + 1)]; i < history[history.Count - 1]; i++) {
							if (history[i] != history[history.Count - 1]) {
								canBreak = false;
							}
						}

						if (canBreak) {
							return false;
						}
					}
				}
			}
			return true;
		}

		public void Read(string file) {

			if (Path.GetExtension(file) == ".ssp") {
				string text = File.ReadAllText(file);

				string[] boards = text.Split(new[] { "Size:" }, StringSplitOptions.None);

				int b_num = 1;

				if (boards.Length > 2) {
					SelectBoard select = new SelectBoard();

					//select.cb_SelectBoard.DataSource = Enumerable.Range(1, boards.Length-1).ToList();
					var dict = new Dictionary<int, string>();

					for (int i = 1; i < boards.Length; i++) {
						var da = boards[i].Replace("Notes:", " ").Split('\n');
						dict.Add(i, "Board #" + i + da[1]);
					}

					var scb = select.cb_SelectBoard;
					scb.DataSource = new BindingSource(dict,null);
					scb.DisplayMember = "Value";
					scb.ValueMember = "Key";


					if (select.ShowDialog() == DialogResult.OK) {
						b_num = Convert.ToInt32(select.cb_SelectBoard.SelectedValue.ToString());
						select.Dispose();
					} else {
						return;
					}
				}

				string[] lines = boards[b_num].Split('\n');

				string[] size = lines[0].Replace("\r","").Replace(" ","").Split(',');

				program.gameBoard = resizeBoard(Convert.ToInt32(size[0]), Convert.ToInt32(size[1]));

				string[] data = boards[b_num].Split(new[] { "Puzzle:" }, StringSplitOptions.None);

				string[] d = Regex.Split(data[1].Replace("\n","").Replace("\r", ""), string.Empty,RegexOptions.IgnorePatternWhitespace);

				for (int x = 0; x < Convert.ToInt32(size[0]); x++) {
					for (int y = 0; y < Convert.ToInt32(size[1]); y++) {
						int x_offset = (int)(x / Math.Sqrt(Convert.ToInt32(size[0])));
						int y_offset = (int)(y / Math.Sqrt(Convert.ToInt32(size[1])));

						var value = d[(x * Convert.ToInt32(size[0])) + (y + 1)];

						if (value == "_") {
							value = "";
						}

						program.gameBoard.GetTile(x + x_offset, y + y_offset).field.Text = value;
					}
				}

			}
		}

		public void SetCount() {
			var gb = program.gameBoard;

			lb_occur.Text = "" + program.gameBoard.FindOccurance(highlightText.Text);
		}

		private TextBox highlightText;
		private TableLayoutPanel highlightTable;
		private Label label1;
		private Button btn_ClearHighlight;
		private CheckBox clickHighlight;
		private Label label2;
		private Label lb_occur;
		private Button btn_ClearGrid;
		private Button btn_LoadPreset;
		private CheckBox cb_autoFill;
		private Button btn_autoCycle;
		private CheckBox focusHighlight;
		private CheckBox cb_possib;
		private Button button1;
	}
}

