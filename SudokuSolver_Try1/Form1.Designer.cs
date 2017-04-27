using System.Windows.Forms;
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
			this.label2 = new System.Windows.Forms.Label();
			this.lb_occur = new System.Windows.Forms.Label();
			this.btn_autoCycle = new System.Windows.Forms.Button();
			this.btn_ClearGrid = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.cb_possib = new System.Windows.Forms.CheckBox();
			this.focusHighlight = new System.Windows.Forms.CheckBox();
			this.clickHighlight = new System.Windows.Forms.CheckBox();
			this.btn_LoadPreset = new System.Windows.Forms.Button();
			this.tb_presetNum = new System.Windows.Forms.TextBox();
			this.cb_autoFill = new System.Windows.Forms.CheckBox();
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
			this.highlightTable.Controls.Add(this.btn_ClearGrid, 0, 8);
			this.highlightTable.Controls.Add(this.label3, 0, 7);
			this.highlightTable.Controls.Add(this.cb_possib, 0, 5);
			this.highlightTable.Controls.Add(this.focusHighlight, 0, 4);
			this.highlightTable.Controls.Add(this.clickHighlight, 0, 3);
			this.highlightTable.Controls.Add(this.btn_LoadPreset, 1, 8);
			this.highlightTable.Controls.Add(this.tb_presetNum, 1, 7);
			this.highlightTable.Controls.Add(this.cb_autoFill, 1, 5);
			this.highlightTable.Controls.Add(this.btn_ClearHighlight, 1, 4);
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
			this.highlightTable.Size = new System.Drawing.Size(236, 266);
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
			this.btn_autoCycle.Location = new System.Drawing.Point(3, 230);
			this.btn_autoCycle.Name = "btn_autoCycle";
			this.btn_autoCycle.Size = new System.Drawing.Size(230, 33);
			this.btn_autoCycle.TabIndex = 11;
			this.btn_autoCycle.Text = "Auto Cycle";
			this.btn_autoCycle.UseVisualStyleBackColor = true;
			this.btn_autoCycle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_autoCycle_MouseUp);
			// 
			// btn_ClearGrid
			// 
			this.btn_ClearGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_ClearGrid.Location = new System.Drawing.Point(3, 172);
			this.btn_ClearGrid.Name = "btn_ClearGrid";
			this.btn_ClearGrid.Size = new System.Drawing.Size(109, 42);
			this.btn_ClearGrid.TabIndex = 7;
			this.btn_ClearGrid.Text = "Clear Grid";
			this.btn_ClearGrid.UseVisualStyleBackColor = true;
			this.btn_ClearGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_ClearGrid_MouseUp);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 143);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 26);
			this.label3.TabIndex = 14;
			this.label3.Text = "Preset Number:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cb_possib
			// 
			this.cb_possib.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cb_possib.AutoSize = true;
			this.cb_possib.Location = new System.Drawing.Point(3, 107);
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
			this.focusHighlight.Size = new System.Drawing.Size(109, 26);
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
			this.btn_LoadPreset.Location = new System.Drawing.Point(118, 172);
			this.btn_LoadPreset.Name = "btn_LoadPreset";
			this.btn_LoadPreset.Size = new System.Drawing.Size(115, 27);
			this.btn_LoadPreset.TabIndex = 8;
			this.btn_LoadPreset.Text = "Load Preset";
			this.btn_LoadPreset.UseVisualStyleBackColor = true;
			this.btn_LoadPreset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_LoadPreset_MouseUp);
			// 
			// tb_presetNum
			// 
			this.tb_presetNum.Location = new System.Drawing.Point(118, 146);
			this.tb_presetNum.Name = "tb_presetNum";
			this.tb_presetNum.Size = new System.Drawing.Size(115, 20);
			this.tb_presetNum.TabIndex = 9;
			// 
			// cb_autoFill
			// 
			this.cb_autoFill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cb_autoFill.Location = new System.Drawing.Point(118, 107);
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
			this.btn_ClearHighlight.Size = new System.Drawing.Size(115, 26);
			this.btn_ClearHighlight.TabIndex = 3;
			this.btn_ClearHighlight.Text = "Clear Highlight";
			this.btn_ClearHighlight.UseVisualStyleBackColor = true;
			this.btn_ClearHighlight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_ClearHighlight_MouseUp);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(321, 427);
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
			int w_sq = (int)Math.Sqrt(_w);
			int h_sq = (int)Math.Sqrt(_h);

			boardGrid.ColumnCount = _w + (w_sq - 1);
			boardGrid.RowCount = _h + (h_sq - 1);

			Board gameBoard = new Board(boardGrid.ColumnCount, boardGrid.RowCount);

			boardGrid.SuspendLayout();
			boardGrid.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
			boardGrid.ColumnStyles.Clear();
			boardGrid.RowStyles.Clear();

			for (var x = 0; x < gameBoard.width; x++) {
				for (var y = 0; y < gameBoard.height; y++) {
					Tile obj = gameBoard.tiles[x, y];

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
			Tile obj = program.gameBoard.tiles[_x, _y];
			if (obj.hasField) {
				obj.field.BackColor = _color;
			}
			obj.panel.BackColor = _color;
		}

		public void CreateHighlight(string num) {
			if (focusHighlight.Checked) {
				RemoveHighlight(Color.Yellow, true);
				for (int x = 0; x < program.gameBoard.width; x++) {
					for (int y = 0; y < program.gameBoard.height; y++) {
						if (program.gameBoard.tiles[x, y].value == num && num != "") {
							UpdateColorSquare(x, y, Color.Yellow, true);
						}
					}
				}
			}
		}

		public void RemoveHighlight(Color _color, bool other = false) {
			for (int x = 0; x < program.gameBoard.width; x++) {
				for (int y = 0; y < program.gameBoard.height; y++) {
					if (program.gameBoard.GetTile(x, y).hasField) {
						if (other) {
							if (program.gameBoard.tiles[x, y].field.BackColor == _color) {
								UpdateColorSquare(x, y, Color.White, true);
							}
						} else {
							if (program.gameBoard.tiles[x, y].field.BackColor != _color) {
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

			int[,] poss = new int[gb.width, gb.height];

			for (int x = 0; x < gb.width; x++) {
				for (int y = 0; y < gb.height; y++) {

					if (gb.tiles[x, y].value == "" && gb.tiles[x, y].hasField) {
						var col = gb.GetColumn(y);
						var row = gb.GetRow(x);
						var group = gb.GetGroup(gb.tiles[x, y].group);

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

				for (int x = 0; x < gb.width; x++) {
					for (int y = 0; y < gb.height; y++) {

						if (poss[x, y] == 1) {
							UpdateColorSquare(x, y, Color.LightGreen);
						}

					}
				}

				if (mode == 0) {
					for (int x = 0; x < gb.width; x++) {
						for (int y = 0; y < gb.height; y++) {
							if (poss[x, y] == 1) {
								var group = gb.GetGroup(gb.tiles[x, y].group);
								var row = gb.GetRow(x);
								var column = gb.GetColumn(y);

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
											gb.tiles[x, y].field.Text = "" + pos;
										} else {
											UpdateColorSquare(x, y, Color.Green);
										}
									}
								}
							}
						}
					}
				} else if (mode == 1) {
					gb.LoadDataset(Convert.ToInt32(tb_presetNum.Text)-1);
					int x = 0;
					int y = 0;
					int count = 0;
					while (true) {
						Random rnd = new Random();
						x = rnd.Next(1, 9);
						y = rnd.Next(1, 9);

						if (poss[x, y] == 1) {
							Console.WriteLine(x + "," + y);
							break;
						}
					}

					return;

				}

				if (program.lastExec != null) {
					rcHighlight(program.lastExec);
				}

			}
		}

		/// <summary>
		/// For testing only.
		/// </summary>
		public void doTest() {
			List<long> times = new List<long>();

			for (int i = 0; i < 20; i++) {
				program.gameBoard.LoadDataset(5);
				var sw = System.Diagnostics.Stopwatch.StartNew();
				sw.Start();
				MasterCycle();
				sw.Stop();
				times.Add(sw.ElapsedMilliseconds);
			}

			long total_time = 0;
			foreach (var item in times) {
				total_time += item;
			}

			Console.WriteLine(total_time / times.Count);

			
		}

		public void MasterCycle(int tollerance = 10) {
			// Do cycles of checking for possibilities.
			// If it gets stuck:
			//	Start a random guess, see it through, and if it doesn't work, re-guess.

			// Numbers that are not fully solved yet.
			List<int> left = new List<int>();

			// The history of what has happened.
			List<int> history = new List<int>();

			for (int i = 1; i < 10; i++) {
				left.Add(i);
			}

			var gb = program.gameBoard;
			while (gb.FindOccurance("") != 0) {

				List<int> _left = new List<int>();
				history.Add(gb.FindOccurance(""));

				foreach (var item in left) {
					// Basic check for possibilities.
					ShowPossibilities("" + item, true);

					//Console.WriteLine(gb.FindOccurance(""));

					if (gb.FindOccurance("" + item) < 9) {
						_left.Add(item);
					}
				}

				left = _left;

				if (gb.FindOccurance("") == 0) {
					// The gameboard is full!
					return;
				} else if (history.Count > tollerance) {
					if (history[history.Count - (tollerance + 1)] == history[history.Count - 1]) {
						bool canBreak = true;
						for (int i = history[history.Count - (tollerance + 1)]; i < history[history.Count - 1]; i++) {
							if (history[i] != history[history.Count - 1]) {
								canBreak = false;
							}
						}

						if (canBreak) {
							// By this point, the program has gotten stuck so it needs some help.
							// Create a restore point incase the random guess doesn't work and
							// finally, do a random guess to see if it will work.

							string[,] restorePoint = new string[gb.width, gb.height];

							for (int _x = 0; _x < gb.width; _x++) {
								for (int _y = 0; _y < gb.height; _y++) {
									if (gb.tiles[_x, _y].hasField) {
										restorePoint[_x, _y] = gb.tiles[_x, _y].field.Text.ToString();
									} else {
										restorePoint[_x, _y] = null;
									}
								}
							}

							// Pick a random number from what is left.
							Random rnd_entry = new Random();

							if (GuessCycle(left[rnd_entry.Next(0,left.Count-1)])) {
								// Yay! The random guess worked and the program was able to
								// completly solve the sudoku puzzle. Exit the while loop.
								return;
							} else {
								// Oh no. The random guess did not work. Reset the board to before
								// the random guess and try again.

								Console.WriteLine("Guess Failed :( Empty spaces left: " + gb.FindOccurance(""));

								for (int _x = 0; _x < gb.width; _x++) {
									for (int _y = 0; _y < gb.height; _y++) {
										if (gb.tiles[_x, _y].hasField) {
											gb.tiles[_x, _y].field.Text = restorePoint[_x, _y].ToString();
										}
									}
								}
							}
						}
					}
				}
			}
		}

		public bool GuessCycle(int num,int tollerance = 10) {
			Console.WriteLine("Started a random guess! Tollerance: " + tollerance);

			var gb = program.gameBoard;
			int x;
			int y;
			int[,] poss = GetPossibilities("" + num);
			while (true) {
				Random rnd = new Random();
				x = rnd.Next(1, 9);
				y = rnd.Next(1, 9);

				if (poss[x, y] == 1) {
					Console.WriteLine("("+x + "," + y+") = "+num);
					gb.tiles[x, y].field.Text = "" + num;
					break;
				}
			}

			List<int> left = new List<int>();
			List<int> history = new List<int>();
			for (int i = 1; i < 10; i++) {
				left.Add(i);
			}

			while (gb.FindOccurance("") != 0) {

				List<int> _left = new List<int>();
				history.Add(gb.FindOccurance(""));

				foreach (var item in left) {
					// Basic check for possibilities.
					ShowPossibilities("" + item, true);

					//Console.WriteLine(gb.FindOccurance(""));

					if (gb.FindOccurance("" + item) < 9) {
						_left.Add(item);
					}
				}

				left = _left;

				if (gb.FindOccurance("") == 0) {
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

		/*public bool Cycle(int tollerance = 20, bool master = true) {
			List<int> a_left = new List<int>();
			List<int> history = new List<int>();
			for (int i = 1; i < 10; i++) {
				a_left.Add(i);
			}
			//for (int i = 0; i < 30; i++) {
			var gb = program.gameBoard;
			while (gb.FindOccurance("") != 0) {

				List<int> b_left = new List<int>();
				history.Add(gb.FindOccurance(""));

				foreach (var item in a_left) {
					ShowPossibilities("" + item, true);

					Console.WriteLine(gb.FindOccurance(""));

					if (gb.FindOccurance("" + item) < 9) {
						b_left.Add(item);
					}
				}

				a_left = b_left;

				if (gb.FindOccurance("") == 0) {
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
							if (master) {
								int x;
								int y;
								bool didSomething = false;
								int[,] poss = GetPossibilities("" + a_left[0]);
								while (true) {
									if (a_left.Count > 0) {
										Random rnd = new Random();
										x = rnd.Next(1, 9);
										y = rnd.Next(1, 9);

										if (poss[x, y] == 1) {
											Console.WriteLine(x + "," + y);
											gb.tiles[x, y].field.Text = "" + a_left[0];
											didSomething = true;
											break;
										}
									} else {
										return false;
									}
								}

								string[,] restorePoint = new string[gb.width, gb.height];

								for (int _x = 0; _x < gb.width; _x++) {
									for (int _y = 0; _y < gb.height; _y++) {
										if (gb.tiles[_x, _y].hasField) {
											restorePoint[_x, _y] = gb.tiles[_x, _y].field.Text.ToString();
										} else {
											restorePoint[_x, _y] = null;
										}
									}
								}

								if (didSomething) {
									if (Cycle(20, false)) {
										Console.WriteLine("=)");
									} else {
										Console.WriteLine(":(");
										for (int _x = 0; _x < gb.width; _x++) {
											for (int _y = 0; _y < gb.height; _y++) {
												if (gb.tiles[_x, _y].hasField) {
													gb.tiles[_x, _y].field.Text = restorePoint[_x, _y].ToString();
												}
											}
										}
									}
								}

							} else {
								if (a_left.Count > 0) {
									Console.WriteLine("Returned false.");
									return false;
								}
								return true;
							}
						}
					}
				}
			}
			return true;
		}*/

		public void SetCount() {
			var gb = program.gameBoard;
			int count = 0;
			for (int x = 0; x < gb.width; x++) {
				for (int y = 0; y < gb.height; y++) {

					if (gb.tiles[x, y].value == highlightText.Text && gb.tiles[x, y].hasField && gb.tiles[x, y].value != "") {
						count += 1;
					}
				}
			}

			lb_occur.Text = "" + count;
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
		private TextBox tb_presetNum;
		private CheckBox cb_autoFill;
		private Button btn_autoCycle;
		private CheckBox focusHighlight;
		private CheckBox cb_possib;
		private Label label3;
	}
}

