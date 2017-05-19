using System;
using System.Windows.Forms;

namespace SudokuSolver_Try1 {
	public class Program {

		private Tile lastExec = null;
		public Tile LastExec {
			get {
				return lastExec;
			}

			set {
				this.lastExec = value;
			}
		}

		private GameBoard gameboard;
		public GameBoard Gameboard {
			get {
				return gameboard;
			}

			set {
				this.gameboard = value;
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
			var size = new int[] { 9, 9 };
			program.gameboard = new GameBoard(size[0],size[1]);

			// Create and resize the game board!
			form.resizeBoard(size[0], size[1]);

			Application.Run(form);

		}
	}
}
