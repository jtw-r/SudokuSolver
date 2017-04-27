using System;
using System.Windows.Forms;

namespace SudokuSolver_Try1 {
	public class Program {

		public Board gameBoard;
		public Tile lastExec = null;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Form1 form = new Form1();
			Program program = new Program();
			form.program = program;

			int[] board_size = { 9, 9 };

			program.gameBoard = form.resizeBoard(board_size[0], board_size[1]);
			
			Application.Run(form);

		}

		/*Board NewBoard(int[] board_size) {
			return new Board(board_size[0], board_size[1]);
		}*/
	}
}
