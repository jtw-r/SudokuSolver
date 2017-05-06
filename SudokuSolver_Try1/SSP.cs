using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver_Try1 {
	class SSP {

		Program program;
		Form1 form1;

		public SSP(Program _program, Form1 _form) {
			program = _program;
			form1 = _form;
		}

		public void Load(string filename = null) {
			if (filename == null) {
				OpenFileDialog fileDG = new OpenFileDialog();
				fileDG.DefaultExt = ".ssp";
				fileDG.Filter = "Sudoku Solver Puzzles (.ssp)|*.ssp";

				var result = fileDG.ShowDialog();

				if (result == DialogResult.OK) {
					filename = @fileDG.FileName;
					fileDG.Dispose();
				} else {
					return;
				}
			}

			if (Path.GetExtension(filename) == ".ssp") {
				string text = File.ReadAllText(filename);

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
					scb.DataSource = new BindingSource(dict, null);
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

				string[] size = lines[0].Replace("\r", "").Replace(" ", "").Split(',');

				program.gameBoard = form1.resizeBoard(Convert.ToInt32(size[0]), Convert.ToInt32(size[1]));

				string[] data = boards[b_num].Split(new[] { "Puzzle:" }, StringSplitOptions.None);

				string[] d = Regex.Split(data[1].Replace("\n", "").Replace("\r", ""), string.Empty, RegexOptions.IgnorePatternWhitespace);

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

		public void Save(string filename = null) {
			if (filename == null) {
				SaveFileDialog fileDG = new SaveFileDialog();
				fileDG.DefaultExt = ".ssp";
				fileDG.Filter = "Sudoku Solver Puzzles (.ssp)|*.ssp";

				var result = fileDG.ShowDialog();

				if (result == DialogResult.OK) {
					filename = @fileDG.FileName;
					fileDG.Dispose();
				} else {
					return;
				}
			}

			DateTime time = DateTime.Now;

			string[] lines = {	"Size: "+program.Board_size[0]+","+program.Board_size[1],
								"Notes: "+time.ToString(new CultureInfo("en-US")),
								"Puzzle:"};

			string[] puzzle = new string[program.Board_size[0]];

			for (int x = 0; x < program.gameBoard.Width; x++) {
				for (int y = 0; y < program.gameBoard.Height; y++) {
					if (!form1.isSqrt(x, (int)Math.Sqrt(program.Board_size[0])) && !form1.isSqrt(y, (int)Math.Sqrt(program.Board_size[1]))) {
						var value = program.gameBoard.GetTile(x, y).field.Text;

						if (value == "") {
							value = "_";
						}

						int x_offset = (int)Math.Floor((float)((x + 1) / (Math.Sqrt(program.Board_size[0]) + 1)));

						puzzle[x - (x_offset)] += value;
					}
				}
			}

			string text = "Do you want to overide the boards in this file?\nNo preexisting boards may exist in this file. This is just a generic warning.\nYes = overide. No = append.";
			string caption = "Overide boards?";

			DialogResult results = MessageBox.Show(text, caption, MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

			switch (results) {
				case DialogResult.Yes:
					File.WriteAllLines(filename, lines);
					File.AppendAllLines(filename, puzzle);
				break;
				case DialogResult.No:
					File.AppendAllLines(filename, lines);
					File.AppendAllLines(filename, puzzle);
				break;
				case DialogResult.Cancel:
				return;
			}

		}

	}

}
