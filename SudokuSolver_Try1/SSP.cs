using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SudokuSolver_Try1 {
	class SSP {

		Program program;
		MainUI form;

		public SSP(Program _program, MainUI _form) {
			program = _program;
			form = _form;
		}

		public void Load(string filename = null) {
			if (filename == null) {
				// No file name was specified. Open up a file selection dialog box.
				OpenFileDialog saveFileDG = new OpenFileDialog();
				saveFileDG.DefaultExt = ".ssp";
				saveFileDG.Filter = "Sudoku Solver Puzzles (.ssp)|*.ssp";

				// Show the dialog box to the user.
				var result = saveFileDG.ShowDialog();

				// Get the users input.
				if (result == DialogResult.OK) {
					filename = saveFileDG.FileName;
					saveFileDG.Dispose();
				} else {
					saveFileDG.Dispose();
					return;
				}
			}

			if (Path.GetExtension(filename) == ".ssp") {
				// Get all of the text from the selected file.
				string fileContents = File.ReadAllText(filename);

				// Set up an array of the boards in this file.
				string[] boards = fileContents.Split(new[] { "Size:" }, StringSplitOptions.None);

				int selectedBoardNumber = 1;
				if (boards.Length > 2) {
					// If there is more than one board in this file,
					// ask which one the user would like.
					SelectBoardUI select = new SelectBoardUI();

					var options = new Dictionary<int, string>();

					// Create a list (dictionary) of boards.
					for (int i = 1; i < boards.Length; i++) {
						var entry = boards[i].Replace("Notes:", " ").Split('\n');
						if (entry[1].Contains("Puzzle:")) {
							// No note was attached to the board,
							// Give it a number insted.
							options.Add(i, "Board #" + i);
						} else {
							// Show the user the note that was attached to the board.
							options.Add(i, "Board #" + i + entry[1]);
						}
					}

					// Set the combo-box to display the options.
					var selectBoardComboBox = select.cb_SelectBoard;
					selectBoardComboBox.DataSource = new BindingSource(options, null);
					selectBoardComboBox.DisplayMember = "Value";
					selectBoardComboBox.ValueMember = "Key";

					// Display the prompt to the user.
					if (select.ShowDialog() == DialogResult.OK) {
						selectedBoardNumber = Convert.ToInt32(selectBoardComboBox.SelectedValue.ToString());
						select.Dispose();
					} else {
						select.Dispose();
						return;
					}
				}

				// Get all of the lines in the selected board.
				string[] fileLines = boards[selectedBoardNumber].Split('\n');

				// Get the board size from the file.
				string[] boardSize = fileLines[0].Replace("\r", "").Replace(" ", "").Split(',');

				// Resize the main ui board to match the file size.
				form.resizeBoard(Convert.ToInt32(boardSize[0]), Convert.ToInt32(boardSize[1]));

				// Get the data from the board.
				string[] selectedBoardData = boards[selectedBoardNumber].Split(new[] { "Puzzle:" }, StringSplitOptions.None);
				string[] boardData = Regex.Split(selectedBoardData[1].Replace("\n", "").Replace("\r", ""), string.Empty, RegexOptions.IgnorePatternWhitespace);

				if (boardData.Length/ Convert.ToInt32(boardSize[1]) == Convert.ToInt32(boardSize[0])) {
					for (int x = 0; x < Convert.ToInt32(boardSize[0]); x++) {
						for (int y = 0; y < Convert.ToInt32(boardSize[1]); y++) {
							// Calculate the offset of the coordinates.
							int x_offset = (int)(x / Math.Sqrt(Convert.ToInt32(boardSize[0])));
							int y_offset = (int)(y / Math.Sqrt(Convert.ToInt32(boardSize[1])));

							// Get the data from the board.
							var value = boardData[(x * Convert.ToInt32(boardSize[0])) + (y + 1)];

							// Format empty spaces.
							if (value == "_") {
								value = "";
							}

							// Apply the file data to the actually data array.
							program.Gameboard.UpdateFromData(x + x_offset, y + y_offset, value);
						}
					}
					return;
				}

			}
			// Oh no! Something went wrong. Let the user know.
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
							   "Size: " +program.Gameboard.FauxDimensions[0]+","+program.Gameboard.FauxDimensions[1],
							   "Notes: "+time.ToString(new CultureInfo("en-US")),
							   "Puzzle:"};

			string[] puzzle = new string[program.Gameboard.UIboard.Width];

			for (int x = 0; x < program.Gameboard.UIboard.Width; x++) {
				for (int y = 0; y < program.Gameboard.UIboard.Height; y++) {
					if (program.Gameboard.Databoard.GetCell(x,y) != null) {
						var value = program.Gameboard.Databoard.GetCell(x, y).Value;

						// Format blank spaces.
						if (value == "") {
							value = "_";
						}

						int x_offset = (int)Math.Floor((float)((x + 1) / (Math.Sqrt(program.Gameboard.UIboard.Width) + 1)));

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
