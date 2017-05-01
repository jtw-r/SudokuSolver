namespace SudokuSolver_Try1 {
	partial class SelectBoard {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.cb_SelectBoard = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cb_SelectBoard
			// 
			this.cb_SelectBoard.FormattingEnabled = true;
			this.cb_SelectBoard.Items.AddRange(new object[] {
            "Hi"});
			this.cb_SelectBoard.Location = new System.Drawing.Point(5, 5);
			this.cb_SelectBoard.Name = "cb_SelectBoard";
			this.cb_SelectBoard.Size = new System.Drawing.Size(156, 21);
			this.cb_SelectBoard.TabIndex = 0;
			this.cb_SelectBoard.SelectedIndexChanged += new System.EventHandler(this.cb_SelectBoard_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(86, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 29);
			this.button1.TabIndex = 1;
			this.button1.Text = "Ok";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(5, 32);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 29);
			this.button2.TabIndex = 2;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// SelectBoard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(171, 68);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cb_SelectBoard);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SelectBoard";
			this.Padding = new System.Windows.Forms.Padding(2);
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Select Board";
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.ComboBox cb_SelectBoard;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}