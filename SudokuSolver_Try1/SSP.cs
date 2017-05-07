using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SudokuSolver_Try1 {
	class SSP {

		Program program;
		MainUI form1;

		public SSP(Program _program, MainUI _form) {
			program = _program;
			form1 = _form;
		}

		public void Load(string filename = null) {
			if (filename == null) {
				OpenFileDialog saveFileDG = new OpenFileDialog();
				saveFileDG.DefaultExt = ".ssp";
				saveFileDG.Filter = "Sudoku Solver Puzzles (.ssp)|*.ssp";

				var result = saveFileDG.ShowDialog();

				if (result == DialogResult.OK) {
					filename = saveFileDG.FileName;
					saveFileDG.Dispose();
				} else {
					return;
				}
			}

			if (Path.GetExtension(filename) == ".ssp") {
				string fileContents = File.ReadAllText(filename);

				string[] boards = fileContents.Split(new[] { "Size:" }, StringSplitOptions.None);

				int selectedBoardNum = 1;

				if (boards.Length > 2) {
					SelectBoardUI select = new SelectBoardUI();

					var dict = new Dictionary<int, string>();

					for (int i = 1; i < boards.Length; i++) {
						var da = boards[i].Replace("Notes:", " ").Split('\n');
						if (da[1].Contains("Puzzle:")) {
							dict.Add(i, "Board #" + i);
						} else {
							dict.Add(i, "Board #" + i + da[1]);
						}
					}

					var selectBoardComboBox = select.cb_SelectBoard;
					selectBoardComboBox.DataSource = new BindingSource(dict, null);
					selectBoardComboBox.DisplayMember = "Value";
					selectBoardComboBox.ValueMember = "Key";


					if (select.ShowDialog() == DialogResult.OK) {
						selectedBoardNum = Convert.ToInt32(selectBoardComboBox.SelectedValue.ToString());
						select.Dispose();
					} else {
						return;
					}
				}

				string[] fileLines = boards[selectedBoardNum].Split('\n');

				string[] boardSize = fileLines[0].Replace("\r", "").Replace(" ", "").Split(',');

				program.GameBoard = form1.resizeBoard(Convert.ToInt32(boardSize[0]), Convert.ToInt32(boardSize[1]));

				string[] selectedBoardData = boards[selectedBoardNum].Split(new[] { "Puzzle:" }, StringSplitOptions.None);

				string[] boardData = Regex.Split(selectedBoardData[1].Replace("\n", "").Replace("\r", ""), string.Empty, RegexOptions.IgnorePatternWhitespace);

				if (boardData.Length/ Convert.ToInt32(boardSize[1]) == Convert.ToInt32(boardSize[0])) {
					for (int x = 0; x < Convert.ToInt32(boardSize[0]); x++) {
						for (int y = 0; y < Convert.ToInt32(boardSize[1]); y++) {
							int x_offset = (int)(x / Math.Sqrt(Convert.ToInt32(boardSize[0])));
							int y_offset = (int)(y / Math.Sqrt(Convert.ToInt32(boardSize[1])));

							var value = boardData[(x * Convert.ToInt32(boardSize[0])) + (y + 1)];

							if (value == "_") {
								value = "";
							}

							program.GameBoard.GetTile(x + x_offset, y + y_offset).field.Text = value;
						}
					}
					return;
				}

			}
			MessageBox.Show("This file is not the correct format", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		public void Save(string filename = null) {
			if (filename == null) {
				SaveFileDialog saveFileDG = new SaveFileDialog();
				saveFileDG.DefaultExt = ".ssp";
				saveFileDG.Filter = "Sudoku Solver Puzzles (.ssp)|*.ssp";

				if (saveFileDG.ShowDialog() == DialogResult.OK) {
					filename = saveFileDG.FileName;
					saveFileDG.Dispose();
				} else {
					return;
				}
			}

			DateTime time = DateTime.Now;

			string[] begining = { "/////////////////////////////////////////////////////////////", "// Sudoku Solver Puzzle                                    //", "//                             (c) 2017 Jonathan Reiterman //", "// '_' denotes a blank cell                                //", "/////////////////////////////////////////////////////////////" };

			string[] lines = { "",
							   "Size: " +program.GameBoard.Width+","+program.GameBoard.Height,
							   "Notes: "+time.ToString(new CultureInfo("en-US")),
							   "Puzzle:"};

			string[] puzzle = new string[program.GameBoard.Width];

			for (int x = 0; x < program.GameBoard.Width; x++) {
				for (int y = 0; y < program.GameBoard.Height; y++) {
					if (!form1.isSqrt(x, (int)Math.Sqrt(program.GameBoard.Width)) && !form1.isSqrt(y, (int)Math.Sqrt(program.GameBoard.Height))) {
						var value = program.GameBoard.GetTile(x, y).field.Text;

						if (value == "") {
							value = "_";
						}

						int x_offset = (int)Math.Floor((float)((x + 1) / (Math.Sqrt(program.GameBoard.Width) + 1)));

						puzzle[x - (x_offset)] += value;
					}
				}
			}

			string[] fileBoards;

			if (File.Exists(filename)) {
				fileBoards = File.ReadAllText(filename).Split(new[] { "Size:" }, StringSplitOptions.None);
			} else {
				fileBoards = new [] {""};
			}

			if (fileBoards.Length > 1) {

				string text = "This file aready contains boards.";
				string caption = "Overide existing boards?";

				ConfirmationUI conf = new ConfirmationUI(caption, text, "Overide", "Cancel", "Append");

				DialogResult result = conf.ShowDialog();

				switch (result) {
					case DialogResult.No:
						// Overwrite
						File.WriteAllLines(filename, begining);
						File.AppendAllLines(filename, lines);
						File.AppendAllLines(filename, puzzle);
					break;
					case DialogResult.Yes:
						// Append
						File.AppendAllLines(filename, lines);
						File.AppendAllLines(filename, puzzle);
					break;
					case DialogResult.Cancel:
					return;
				}
				conf.Dispose();
			} else {
				File.WriteAllLines(filename, begining);
				File.AppendAllLines(filename, lines);
				File.AppendAllLines(filename, puzzle);
			}

		}

	}

}
