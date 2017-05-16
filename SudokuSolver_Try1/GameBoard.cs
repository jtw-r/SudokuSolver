using System;
using System.Drawing;
using System.Windows.Forms;

namespace SudokuSolver_Try1 {
	public class GameBoard {

		private int[] fauxDimensions;
		public int[] FauxDimensions {
			get {
				return fauxDimensions;
			}

			set {
				this.fauxDimensions = value;
			}
		}

		// Array containing all of the data.
		private DataBoard databoard;
		public DataBoard Databoard {
			get {
				return databoard;
			}

			set {
				this.databoard = value;
			}
		}

		// Array containing all of the UI elements.
		private UIBoard uiboard;
		public UIBoard UIboard {
			get {
				return uiboard;
			}

			set {
				this.uiboard = value;
			}
		}

		// A shortcut to uiboard.highlight, so you don't have to type out:
		// program.Gameboard.Uiboard.highlight.CreateFocusHighlight();
		private Highlight uiHighlight;
		public Highlight UIHighlight {
			get {
				return uiHighlight;
			}

			set {
				this.uiHighlight = value;
			}
		}

		public GameBoard(int _w, int _h) {
			this.fauxDimensions = new[] { _w, _h};
			this.databoard = new DataBoard(_w, _h);
			this.uiboard = new UIBoard(_w, _h);
			this.uiHighlight = this.uiboard.highlight;
		}

		/// <summary>
		/// Maybe don't use?
		/// </summary>
		/// <param name="_w"></param>
		/// <param name="_h"></param>
		/// <returns></returns>
		/*private UIBoard resizeBoard(int _w, int _h) {

			// Remove any pre-existing grids.
			var d = this.Controls.Find("boardGrid", false);
			if (d.Length > 0) {
				d[0].Dispose();
			}

			// Create a new grid.
			TableLayoutPanel boardGrid = new TableLayoutPanel();
			boardGrid.Name = "boardGrid";
			boardGrid.Location = new Point(12, 12);
			boardGrid.AutoSize = AutoSize;
			boardGrid.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

			this.Controls.Add(boardGrid);
			int w_sq = (int)Math.Sqrt(_w);
			int h_sq = (int)Math.Sqrt(_h);

			// Resize the grid.
			boardGrid.ColumnCount = _w + (w_sq - 1);
			boardGrid.RowCount = _h + (h_sq - 1);

			// Create all of the nessicary arrays.
			UIBoard gameBoard = new UIBoard(boardGrid.ColumnCount, boardGrid.RowCount);
			program.Databoard = new DataBoard(boardGrid.ColumnCount, boardGrid.RowCount);

			// Start the design process for the grid.
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

						//obj.field.Text = "" + program.Databoard.GetCell(x, y).Group;

						obj.field.KeyPress += (sender, e) => TextChanged(sender, obj, e, true);
						obj.field.Click += (sender, e) => highlight_Click(sender, obj, e);

						obj.hasField = true;
					}
					gameBoard.highlight.SetColorSquare(x, y, Highlight.DepthType.Possibilities, Color.White);
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
						//col[_x].panel.BackColor = Color.Black;
						gameBoard.highlight.SetColorSquare(_x, a, Highlight.DepthType.Possibilities, Color.Black, false);
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
						gameBoard.highlight.SetColorSquare(b, _y, Highlight.DepthType.Possibilities, Color.Black, false);
					}
				}
				boardGrid.RowStyles.Add(rs);
			}

			boardGrid.ResumeLayout();

			OptionsTable.Location = new Point(boardGrid.Size.Width + Padding.Left * 2, 5 + Padding.Top);

			return gameBoard;

		}*/

		// UPDATE METHODS:

		/// <summary>
		/// Aligns the data array with the textboxes.
		/// </summary>
		public void UpdateFromTextbox(Tile obj) {
			int x = obj.X;
			int y = obj.Y;
			if (obj.hasField) { databoard.GetCell(x, y).Value = obj.field.Text; }
			Console.WriteLine("(" + x + "," + y + ") = " + databoard.GetCell(x, y).Value);
		}

		/// <summary>
		/// Aligns the textboxes with the data array.
		/// </summary>
		public void UpdateFromData(int x, int y) {
			if(uiboard.GetTile(x,y).hasField) { uiboard.GetTile(x, y).field.Text = databoard.GetCell(x, y).Value; }
		}

	}
}
