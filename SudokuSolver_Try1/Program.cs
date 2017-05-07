using System;
using System.Windows.Forms;

namespace SudokuSolver_Try1 {
	public class Program {

		public Board gameBoard;
		public Tile lastExec = null;
		private static int[] board_size = { 9, 9 };

		public int[] Board_size {
			get {
				return board_size;
			}

			set {
				board_size = value;
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

			program.gameBoard = form.resizeBoard(board_size[0], board_size[1]);

			Application.Run(form);

		}
	}
}
