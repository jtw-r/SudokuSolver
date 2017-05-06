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
			Form1 form = new Form1();
			Program program = new Program();
			form.program = program;
			form.self = form;

			program.gameBoard = form.resizeBoard(board_size[0], board_size[1]);

			//form.Read(@"C:\Users\Photography\Documents\Visual Studio 2015\Projects\SudokuSolver_Try1\SudokuSolver_Try1\presets.ssp");
			
			Application.Run(form);

		}

		/*Board NewBoard(int[] board_size) {
			return new Board(board_size[0], board_size[1]);
		}*/
	}
}
