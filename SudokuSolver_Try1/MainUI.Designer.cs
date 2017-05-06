using System.Windows.Forms;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace SudokuSolver_Try1 {
	partial class MainUI {
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
			this.tb_HighlightText = new System.Windows.Forms.TextBox();
			this.OptionsTable = new System.Windows.Forms.TableLayoutPanel();
			this.lb_FocusNumber = new System.Windows.Forms.Label();
			this.lb_Occurances = new System.Windows.Forms.Label();
			this.lb_OccuranceNumber = new System.Windows.Forms.Label();
			this.btn_Solve = new System.Windows.Forms.Button();
			this.btn_ClearBoard = new System.Windows.Forms.Button();
			this.cb_ShowPossibilities = new System.Windows.Forms.CheckBox();
			this.cb_FocusHighlight = new System.Windows.Forms.CheckBox();
			this.cb_ClickHighlight = new System.Windows.Forms.CheckBox();
			this.cb_AutoFillPossibilities = new System.Windows.Forms.CheckBox();
			this.btn_ClearHighlight = new System.Windows.Forms.Button();
			this.btn_LoadBoard = new System.Windows.Forms.Button();
			this.btn_SaveBoard = new System.Windows.Forms.Button();
			this.OptionsTable.SuspendLayout();
			this.SuspendLayout();
			// 
			// tb_HighlightText
			// 
			this.tb_HighlightText.Location = new System.Drawing.Point(118, 3);
			this.tb_HighlightText.Name = "tb_HighlightText";
			this.tb_HighlightText.Size = new System.Drawing.Size(115, 20);
			this.tb_HighlightText.TabIndex = 1;
			this.tb_HighlightText.TextChanged += new System.EventHandler(this.highlightText_TextChanged);
			// 
			// OptionsTable
			// 
			this.OptionsTable.AutoSize = true;
			this.OptionsTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.OptionsTable.ColumnCount = 2;
			this.OptionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.OptionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.OptionsTable.Controls.Add(this.tb_HighlightText, 1, 0);
			this.OptionsTable.Controls.Add(this.lb_FocusNumber, 0, 0);
			this.OptionsTable.Controls.Add(this.lb_Occurances, 0, 1);
			this.OptionsTable.Controls.Add(this.lb_OccuranceNumber, 1, 1);
			this.OptionsTable.Controls.Add(this.btn_Solve, 0, 10);
			this.OptionsTable.Controls.Add(this.btn_ClearBoard, 0, 7);
			this.OptionsTable.Controls.Add(this.cb_ShowPossibilities, 0, 5);
			this.OptionsTable.Controls.Add(this.cb_FocusHighlight, 0, 4);
			this.OptionsTable.Controls.Add(this.cb_ClickHighlight, 0, 3);
			this.OptionsTable.Controls.Add(this.cb_AutoFillPossibilities, 1, 5);
			this.OptionsTable.Controls.Add(this.btn_ClearHighlight, 1, 4);
			this.OptionsTable.Controls.Add(this.btn_LoadBoard, 1, 7);
			this.OptionsTable.Controls.Add(this.btn_SaveBoard, 1, 8);
			this.OptionsTable.Location = new System.Drawing.Point(34, 15);
			this.OptionsTable.Name = "OptionsTable";
			this.OptionsTable.RowCount = 11;
			this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.OptionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.OptionsTable.Size = new System.Drawing.Size(236, 275);
			this.OptionsTable.TabIndex = 2;
			// 
			// lb_FocusNumber
			// 
			this.lb_FocusNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_FocusNumber.AutoSize = true;
			this.lb_FocusNumber.Location = new System.Drawing.Point(3, 0);
			this.lb_FocusNumber.Name = "lb_FocusNumber";
			this.lb_FocusNumber.Size = new System.Drawing.Size(109, 26);
			this.lb_FocusNumber.TabIndex = 2;
			this.lb_FocusNumber.Text = "Focus Number:";
			this.lb_FocusNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lb_Occurances
			// 
			this.lb_Occurances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_Occurances.AutoSize = true;
			this.lb_Occurances.Location = new System.Drawing.Point(3, 26);
			this.lb_Occurances.Name = "lb_Occurances";
			this.lb_Occurances.Size = new System.Drawing.Size(109, 13);
			this.lb_Occurances.TabIndex = 5;
			this.lb_Occurances.Text = "Occurances:";
			this.lb_Occurances.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lb_OccuranceNumber
			// 
			this.lb_OccuranceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_OccuranceNumber.AutoSize = true;
			this.lb_OccuranceNumber.Location = new System.Drawing.Point(118, 26);
			this.lb_OccuranceNumber.Name = "lb_OccuranceNumber";
			this.lb_OccuranceNumber.Size = new System.Drawing.Size(115, 13);
			this.lb_OccuranceNumber.TabIndex = 6;
			this.lb_OccuranceNumber.Text = "0";
			this.lb_OccuranceNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Solve
			// 
			this.btn_Solve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.OptionsTable.SetColumnSpan(this.btn_Solve, 2);
			this.btn_Solve.Location = new System.Drawing.Point(3, 232);
			this.btn_Solve.Name = "btn_Solve";
			this.btn_Solve.Size = new System.Drawing.Size(230, 40);
			this.btn_Solve.TabIndex = 11;
			this.btn_Solve.Text = "Solve";
			this.btn_Solve.UseVisualStyleBackColor = true;
			this.btn_Solve.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_autoCycle_MouseUp);
			// 
			// btn_ClearBoard
			// 
			this.btn_ClearBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_ClearBoard.Location = new System.Drawing.Point(3, 150);
			this.btn_ClearBoard.Name = "btn_ClearBoard";
			this.OptionsTable.SetRowSpan(this.btn_ClearBoard, 2);
			this.btn_ClearBoard.Size = new System.Drawing.Size(109, 66);
			this.btn_ClearBoard.TabIndex = 7;
			this.btn_ClearBoard.Text = "Clear Board";
			this.btn_ClearBoard.UseVisualStyleBackColor = true;
			this.btn_ClearBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_ClearGrid_MouseUp);
			// 
			// cb_ShowPossibilities
			// 
			this.cb_ShowPossibilities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cb_ShowPossibilities.AutoSize = true;
			this.cb_ShowPossibilities.Location = new System.Drawing.Point(3, 111);
			this.cb_ShowPossibilities.Name = "cb_ShowPossibilities";
			this.cb_ShowPossibilities.Size = new System.Drawing.Size(109, 23);
			this.cb_ShowPossibilities.TabIndex = 13;
			this.cb_ShowPossibilities.Text = "Show Possibilities";
			this.cb_ShowPossibilities.UseVisualStyleBackColor = true;
			this.cb_ShowPossibilities.CheckedChanged += new System.EventHandler(this.cb_possib_CheckedChanged);
			// 
			// cb_FocusHighlight
			// 
			this.cb_FocusHighlight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cb_FocusHighlight.AutoSize = true;
			this.cb_FocusHighlight.Location = new System.Drawing.Point(3, 75);
			this.cb_FocusHighlight.Name = "cb_FocusHighlight";
			this.cb_FocusHighlight.Size = new System.Drawing.Size(109, 30);
			this.cb_FocusHighlight.TabIndex = 12;
			this.cb_FocusHighlight.Text = "Focus Highlight";
			this.cb_FocusHighlight.UseVisualStyleBackColor = true;
			this.cb_FocusHighlight.CheckedChanged += new System.EventHandler(this.focusHighlight_CheckedChanged);
			// 
			// cb_ClickHighlight
			// 
			this.cb_ClickHighlight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cb_ClickHighlight.AutoSize = true;
			this.cb_ClickHighlight.Checked = true;
			this.cb_ClickHighlight.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cb_ClickHighlight.Location = new System.Drawing.Point(3, 52);
			this.cb_ClickHighlight.Name = "cb_ClickHighlight";
			this.cb_ClickHighlight.Size = new System.Drawing.Size(109, 17);
			this.cb_ClickHighlight.TabIndex = 4;
			this.cb_ClickHighlight.Text = "Click Highlight";
			this.cb_ClickHighlight.UseVisualStyleBackColor = true;
			this.cb_ClickHighlight.CheckedChanged += new System.EventHandler(this.clickHighlight_CheckedChanged);
			// 
			// cb_AutoFillPossibilities
			// 
			this.cb_AutoFillPossibilities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cb_AutoFillPossibilities.Location = new System.Drawing.Point(118, 111);
			this.cb_AutoFillPossibilities.Name = "cb_AutoFillPossibilities";
			this.cb_AutoFillPossibilities.Size = new System.Drawing.Size(115, 23);
			this.cb_AutoFillPossibilities.TabIndex = 10;
			this.cb_AutoFillPossibilities.Text = "Autofill Possibilities";
			this.cb_AutoFillPossibilities.UseVisualStyleBackColor = true;
			this.cb_AutoFillPossibilities.CheckedChanged += new System.EventHandler(this.cb_autoFill_CheckedChanged);
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
			// btn_LoadBoard
			// 
			this.btn_LoadBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_LoadBoard.Location = new System.Drawing.Point(118, 150);
			this.btn_LoadBoard.Name = "btn_LoadBoard";
			this.btn_LoadBoard.Size = new System.Drawing.Size(115, 30);
			this.btn_LoadBoard.TabIndex = 8;
			this.btn_LoadBoard.Text = "Load Board";
			this.btn_LoadBoard.UseVisualStyleBackColor = true;
			this.btn_LoadBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_LoadPreset_MouseUp);
			// 
			// btn_SaveBoard
			// 
			this.btn_SaveBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_SaveBoard.Location = new System.Drawing.Point(118, 186);
			this.btn_SaveBoard.Name = "btn_SaveBoard";
			this.btn_SaveBoard.Size = new System.Drawing.Size(115, 30);
			this.btn_SaveBoard.TabIndex = 14;
			this.btn_SaveBoard.Text = "Save Board";
			this.btn_SaveBoard.UseVisualStyleBackColor = true;
			this.btn_SaveBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Save_MouseDown);
			// 
			// MainUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(321, 385);
			this.Controls.Add(this.OptionsTable);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainUI";
			this.Padding = new System.Windows.Forms.Padding(12);
			this.ShowIcon = false;
			this.Text = "Sudoku Solver";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.OptionsTable.ResumeLayout(false);
			this.OptionsTable.PerformLayout();
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

			OptionsTable.Location = new Point(boardGrid.Size.Width + Padding.Left * 2, 5 + Padding.Top);

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
			if (cb_FocusHighlight.Checked) {
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

		//public int cycleNum = 0;

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
			if (cb_ShowPossibilities.Checked || thing) {
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
									if (cb_AutoFillPossibilities.Checked || thing) {
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

						if (GuessCycle(num)) {
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

		public bool GuessCycle(string[] num,int tollerance = 10) {
			var gb = program.gameBoard;
			for (int a = 0; a < program.gameBoard.FindOccurance("") / 20; a++) {
				for (int i = 0; i < num.Length - 1; i++) {
					int[,] poss = GetPossibilities("" + num[i]);
					Random rnd = new Random();
					int cycle_num = 0;
					while (true) {
						int x = rnd.Next(1, 9);
						int y = rnd.Next(1, 9);

						if (poss[x, y] == 1) {
							program.gameBoard.GetTile(x, y).field.Text = "" + num[i];
							break;
						}
						cycle_num++;
						if (cycle_num > 100) {
							// If this has searched through 100 random positions and
							// none of them work, stop the loop.
							break;
						}
					}
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

		public void SetCount() {
			if (tb_HighlightText.Text != "") {
				var gb = program.gameBoard;

				lb_OccuranceNumber.Text = "" + program.gameBoard.FindOccurance(tb_HighlightText.Text);
			}
		}

		private TextBox tb_HighlightText;
		private TableLayoutPanel OptionsTable;
		private Label lb_FocusNumber;
		private Button btn_ClearHighlight;
		private CheckBox cb_ClickHighlight;
		private Label lb_Occurances;
		private Label lb_OccuranceNumber;
		private Button btn_ClearBoard;
		private Button btn_LoadBoard;
		private CheckBox cb_AutoFillPossibilities;
		private Button btn_Solve;
		private CheckBox cb_FocusHighlight;
		private CheckBox cb_ShowPossibilities;
		private Button btn_SaveBoard;
	}
}

