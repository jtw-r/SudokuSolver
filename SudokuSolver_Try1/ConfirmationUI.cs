using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver_Try1 {
	public partial class ConfirmationUI : Form {
		public ConfirmationUI(string _title, string _message, string _button1, string _button2, string _button3) {
			InitializeComponent();

			lb_MessageContents.Text = _message;
			this.Text = _title;

			if (_button1 == null) {
				btn_Option1.Dispose();
			} else {
				btn_Option1.Text = _button1;
			}
			if (_button2 == null) {
				btn_Option2.Dispose();
			} else {
				btn_Option2.Text = _button2;
			}
			if (_button3 == null) {
				btn_Option3.Dispose();
			} else {
				btn_Option3.Text = _button3;
			}

			int[] hook = { lb_MessageContents.Location.X + lb_MessageContents.Size.Width, lb_MessageContents.Location.Y + lb_MessageContents.Size.Height };
			tlp_ButtonContainer.Location = new Point(10, hook[1]+10);
		}
	}
}
