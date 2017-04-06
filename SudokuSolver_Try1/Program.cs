using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UnityEngine.UI.CanvasScaler;

namespace SudokuSolver_Try1 {
	public class Program {

		public Board gameBoard;

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
			program.gameBoard = program.NewBoard(board_size);

			form.resizeBoard(9, 9);
			form.UpdateColorSquare(4, 8, Color.Red);

			Application.Run(form);

		}

		Board NewBoard(int[] board_size) {
			return new Board(board_size[0], board_size[1]);
		}
	}
}
