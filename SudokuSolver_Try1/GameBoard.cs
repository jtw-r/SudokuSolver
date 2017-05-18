using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SudokuSolver_Try1 {
	public class GameBoard {

		// Dimesions of the usable space on the data array. Ex: 11x11 -> 9x9.
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
		// program.Gameboard.Highlight.CreateFocusHighlight();
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

		////////////////////
		// UPDATE METHODS //
		////////////////////

		/// <summary>
		/// Aligns the data array with the textboxes.
		/// </summary>
		public void UpdateFromTextbox(Tile obj) {
			int x = obj.X;
			int y = obj.Y;
			if (obj.hasField) { databoard.GetCell(x, y).Value = obj.field.Text; }
		}

		/// <summary>
		/// Aligns the textboxes with the data array.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public void UpdateFromData(int x, int y) {
			if(uiboard.GetTile(x,y).hasField) { uiboard.GetTile(x, y).field.Text = databoard.GetCell(x, y).Value; }
			uiboard.UpdateHighlights();
		}

		/// <summary>
		/// Aligns the textboxes with the data array.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="value"></param>
		public void UpdateFromData(int x, int y, string value) {
			if (uiboard.GetTile(x, y).hasField) {
				databoard.GetCell(x, y).Value = value;
				uiboard.GetTile(x, y).field.Text = databoard.GetCell(x, y).Value;
				uiboard.UpdateHighlights();
			}
		}

		/////////////////////
		// SOLVING METHODS //
		/////////////////////

		public bool isSqrt(int val, int sq) {
			int floor = (int)Math.Floor((float)((val + 1) / (sq + 1)));
			float nonfloor = ((float)(val + 1) / (sq + 1));

			if (floor == nonfloor) {
				return true;
			}
			return false;
		}

		public void ActUponPossibilities(string num) {
			var i = databoard.GetPossibilities(num);
			for (int x = 0; x < databoard.Width; x++) {
				for (int y = 0; y < databoard.Height; y++) {
					if (!isSqrt(x, (int)Math.Sqrt(databoard.Width)) && !isSqrt(y, (int)Math.Sqrt(databoard.Height))) {
						if(i[x,y] == -1) {
							//databoard.GetCell(x, y).Value = num;
							UpdateFromData(x, y, num);
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

			var gb = UIboard;
			while (Databoard.FindOccurance("") != 0) {
				// Loop this until the puzzle is solved.

				List<int> _left = new List<int>();
				history.Add(Databoard.FindOccurance(""));

				foreach (var item in left) {
					// Basic check for possibilities.

					// So basicly, we don't want this to be ShowPossibilities();
					// More like ActUponPossibilities();
					ActUponPossibilities("" + item);

					// Add the numbers that still need to be solved
					// to a place holder list.
					if (Databoard.FindOccurance("" + item) < 9) {
						_left.Add(item);
					}
				}

				// After everything is done set the main list to be
				// the place holder.
				left = _left;

				if (Databoard.FindOccurance("") == 0) {
					// The gameboard is full! It solved it.
					return;
				} else if (history.Count > tollerance) {
					// Test if nothing has happened in '10' cycles.
					if (history[history.Count - (tollerance + 1)] == history[history.Count - 1]) {
						// By this point, the program has gotten stuck so it needs some help.
						// Create a restore point incase the random guess doesn't work and
						// finally, do a random guess to see if it will work.

						string[,] restorePoint = new string[UIboard.Width, UIboard.Height];

						for (int _x = 0; _x < UIboard.Width; _x++) {
							for (int _y = 0; _y < UIboard.Height; _y++) {
								if (Databoard.GetCell(_x, _y).Value == null) {
									restorePoint[_x, _y] = null;
								} else {
									restorePoint[_x, _y] = Databoard.GetCell(_x, _y).Value.ToString();
								}
							}
						}

						// Find the number with the least possible spaces left.
						List<string> toSort = new List<string>();
						for (int i = 1; i < 10; i++) {
							if (Databoard.FindOccurance("" + i) < 9) {
								toSort.Add(9 - Databoard.FindOccurance("" + i) + "," + i);
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
							for (int _x = 0; _x < Databoard.Width; _x++) {
								for (int _y = 0; _y < Databoard.Height; _y++) {
									if (restorePoint[_x, _y] == null) {
										Databoard.GetCell(_x, _y).Value = null;
									} else {
										Databoard.GetCell(_x, _y).Value = restorePoint[_x, _y].ToString();
									}
								}
							}
						}
					}
				}
			}
		}

		public bool GuessCycle(string[] num, int tollerance = 10) {
			for (int a = 0; a < Databoard.FindOccurance("") / 20; a++) {
				for (int i = 0; i < num.Length - 1; i++) {
					int[,] poss = Databoard.GetPossibilities("" + num[i]);
					Random rnd = new Random();
					int cycle_num = 0;
					bool t = false;
					while (true) {
						int x = rnd.Next(1, 9);
						int y = rnd.Next(1, 9);

						cycle_num++;
						if (cycle_num > 100) {
							// If this has searched through 100 random positions and
							// none of them work, stop the loop.
							break;
						}
						if (poss[x, y] == 1) {
							Databoard.GetCell(x, y).Value = "" + num[i];
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

			while (Databoard.FindOccurance("") != 0) {

				List<int> _left = new List<int>();
				history.Add(Databoard.FindOccurance(""));

				foreach (var item in left) {
					// Basic check for possibilities.
					ActUponPossibilities("" + item);

					if (Databoard.FindOccurance("" + item) < 9) {
						_left.Add(item);
					}
				}

				left = _left;

				if (Databoard.FindOccurance("") == 0) {
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

	}
}
