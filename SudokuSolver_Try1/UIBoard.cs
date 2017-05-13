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

		private int width;
		private int height;

		public int Width {
			get {
				return width;
			}

			set {
				this.width = value;
			}
		}

		public int Height {
			get {
				return height;
			}

			set {
				this.height = value;
			}
		}

		public UIBoard(int x_length, int y_length) {
			this.width = y_length;
			this.height = x_length;

			tiles = new Tile[width, height];

			for (int x = 0; x < width; x++) {
				for (int y = 0; y < height; y++) {
					tiles[x, y] = new Tile(x, y, null, null, false, width, height);
				}
			}

			highlight = new Highlight(width,height, () => UpdateHighlights());
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

		public void UpdateHighlights() {
			//PartialClear();
			for (int x = 0; x < width; x++) {
				for (int y = 0; y < height; y++) {
					if (tiles[x, y].panel != null) {
						tiles[x, y].panel.BackColor = Color.White;
						if (tiles[x, y].hasField) {
							tiles[x, y].field.BackColor = Color.White;
						}
						for (int d = highlight.Depth - 1; d > 0; d--) {
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

		public void PartialClear() {
			for (int x = 0; x < width; x++) {
				for (int y = 0; y < height; y++) {
					tiles[x, y].panel.BackColor = Color.White;
					if (tiles[x, y].hasField) {
						tiles[x, y].field.BackColor = Color.White;
					}
				}
			}
		}

		/*public List<Tile> GetGroup(int _group) {
			List<Tile> TileGroup = new List<Tile>();
			for (int x = 0; x < Width; x++) {
				for (int y = 0; y < Height; y++) {
					if (tiles[x, y].Group == _group) {
						TileGroup.Add(tiles[x, y]);
					}
				}
			}
			return TileGroup;
		}*/

	}
}
