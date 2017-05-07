using System;
using System.Windows.Forms;

namespace SudokuSolver_Try1 {
	public class Program {

		private Board gameBoard;
		public Board GameBoard {
			get {
				return gameBoard;
			}

			set {
				this.gameBoard = value;
			}
		}

		private Tile lastExec = null;
		public Tile LastExec {
			get {
				return lastExec;
			}

			set {
				this.lastExec = value;
			}
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			MainUI form = new MainUI();
			Program program = new Program();
			form.program = program;
			form.self = form;

			// Create and resize the game board!
			program.GameBoard = form.resizeBoard(9, 9);

			Application.Run(form);

		}
	}
}
