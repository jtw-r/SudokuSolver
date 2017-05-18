using System;
using System.Collections.Generic;
using System.Drawing;

namespace SudokuSolver_Try1 {
	public class Highlight {

		private int width;
		public int Width {
			get {
				return width;
			}

			set {
				this.width = value;
			}
		}

		private int height;
		public int Height {
			get {
				return height;
			}

			set {
				this.height = value;
			}
		}

		private int depth;
		public int Depth {
			get {
				return depth;
			}

			set {
				this.depth = value;
			}
		}


		private Color[,,] colorBoard;

		public enum DepthType { Standard, Click, Possibilities, Focus, Other};
		//public enum DepthType { Other, Focus, Possibilities, Click, Standard};

		private Action updateMethod;

		public Highlight(int _width, int _height, Action _updateMethod,  int _depth = 5) {
			this.width = _width;
			this.height = _height;
			this.depth = _depth;
			this.updateMethod = _updateMethod;

			this.colorBoard = new Color[Width, Height, Depth];

			for (int x = 0; x < _width; x++) {
				for (int y = 0; y < _height; y++) {
					for (int d = 0; d < _depth; d++) {
						colorBoard[x, y, d] = Color.Empty;
					}
				}
			}

		}


		/// <summary>
		/// Highlight any cell in yellow that equals num.
		/// </summary>
		/// <param name="num"></param>
		public void CreateFocusHighlight(DataBoard array, string str) {
			if (str != "") {
				for (int x = 0; x < array.Width; x++) {
					for (int y = 0; y < array.Height; y++) {
						if (array.GetCell(x, y).Value == str) {
							SetColorSquare(x, y, DepthType.Focus, Color.Yellow);
						} else {
							SetColorSquare(x, y, DepthType.Focus, Color.Empty);
						}
					}
				}
			}
		}

		public void SetColorSquare(int _x, int _y, DepthType _d, Color _color, bool _safeMode = true) {
			if (_safeMode) {
				if (_d == DepthType.Standard) {
					_d = DepthType.Click;
				}
			}
			colorBoard[_x, _y, Convert.ToInt32(_d)] = _color;
			updateMethod();
		}

		public void SetColorSquare(int _x, int _y, int _d, Color _color, bool _safeMode = true) {
			if (_safeMode) {
				if (_d == 0) {
					_d = 1;
				}
			}
			colorBoard[_x, _y, _d] = _color;
			updateMethod();
		}

		public Color GetColorSquare(int _x, int _y, DepthType _d) {
			return colorBoard[_x, _y, Convert.ToInt32(_d)];
		}

		public Color GetColorSquare(int _x, int _y, int _d) {
			return colorBoard[_x, _y, _d];
		}

		public int CheckDepth(int _x, int _y) {
			int occ = 0;
			for (int d = 0; d < depth; d++) {
				if (colorBoard[_x,_y,d] != Color.White) {
					occ++;
				}
			}
			return occ;
		}

		public void ClearLayer(DepthType _d) {
			for (int x = 0; x < width; x++) {
				for (int y = 0; y < height; y++) {
					SetColorSquare(x, y, _d, Color.Empty, false);
				}
			}
		}

		public void Clear(bool _safe = true) {
			var _depth = 0;
			if (_safe) {
				_depth = 1;
			}
			for (int x = 0; x < Width; x++) {
				for (int y = 0; y < height; y++) {
					for (int d = _depth; d < depth; d++) {
						SetColorSquare(x, y, d, Color.Empty);
					}
				}
			}
		}
	}
}
