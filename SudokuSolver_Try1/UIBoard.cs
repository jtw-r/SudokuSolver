using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver_Try1 {
	public class UIBoard {

		public Highlight highlight;

		protected Tile[,] tiles;

		public int Width { get; }
		public int Height { get; }

		public UIBoard(int x_length, int y_length) {
			this.Width = y_length;
			this.Height = x_length;

			tiles = new Tile[Width, Height];

			for (int x = 0; x < Width; x++) {
				for (int y = 0; y < Height; y++) {
					tiles[x, y] = new Tile(x, y, null, null, false, Width, Height);
				}
			}

			highlight = new Highlight(Width,Height, () => UpdateHighlights());
		}

		public Tile GetTile(int _x, int _y) {
			return tiles[_x, _y];
		}

		public List<Tile> GetRow(int row) {
			List<Tile> tileRow = new List<Tile>();
			for (int y = 0; y < Height; y++) {
				tileRow.Add(tiles[row, y]);
			}
			return tileRow;
		}

		public List<Tile> GetColumn(int column) {
			List<Tile> TileColumn = new List<Tile>();
			for (int x = 0; x < Width; x++) {
				TileColumn.Add(tiles[x, column]);
			}
			return TileColumn;
		}

		public List<Tile> GetGroup(int _group) {
			List<Tile> TileGroup = new List<Tile>();
			for (int x = 0; x < Width; x++) {
				for (int y = 0; y < Height; y++) {
					if (tiles[x, y].group == _group) {
						TileGroup.Add(tiles[x, y]);
					}
				}
			}
			return TileGroup;
		}

		public void UpdateHighlights() {
			for (int x = 0; x < Width; x++) {
				for (int y = 0; y < Height; y++) {
					if (tiles[x, y].panel != null) {
						tiles[x, y].panel.BackColor = Color.White;
						if (tiles[x, y].hasField) {
							tiles[x, y].field.BackColor = Color.White;
						}
						for (int d = 0; d < highlight.Depth; d++) {
							if (highlight.GetColorSquare(x, y, d) != Color.Empty) {
								tiles[x, y].panel.BackColor = highlight.GetColorSquare(x, y, d);
								if (tiles[x, y].hasField) {
									tiles[x, y].field.BackColor = highlight.GetColorSquare(x, y, d);
								}
							}
						}
					}
				}
			}
		}
	}
}
