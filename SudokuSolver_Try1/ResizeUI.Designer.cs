namespace SudokuSolver_Try1 {
	partial class ResizeUI {
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_Ok = new System.Windows.Forms.Button();
			this.nud_Width = new System.Windows.Forms.NumericUpDown();
			this.nud_Height = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nud_Width)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Height)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Width:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Height:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(154, 26);
			this.label3.TabIndex = 4;
			this.label3.Text = "Dimensions:\r\n(Perfict Squares would be nice)";
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Cancel.Location = new System.Drawing.Point(9, 93);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 5;
			this.btn_Cancel.Text = "&Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			// 
			// btn_Ok
			// 
			this.btn_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btn_Ok.Location = new System.Drawing.Point(90, 93);
			this.btn_Ok.Name = "btn_Ok";
			this.btn_Ok.Size = new System.Drawing.Size(75, 23);
			this.btn_Ok.TabIndex = 6;
			this.btn_Ok.Text = "&Ok";
			this.btn_Ok.UseVisualStyleBackColor = true;
			// 
			// nud_Width
			// 
			this.nud_Width.Location = new System.Drawing.Point(53, 43);
			this.nud_Width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_Width.Name = "nud_Width";
			this.nud_Width.Size = new System.Drawing.Size(120, 20);
			this.nud_Width.TabIndex = 7;
			this.nud_Width.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
			// 
			// nud_Height
			// 
			this.nud_Height.Location = new System.Drawing.Point(53, 68);
			this.nud_Height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_Height.Name = "nud_Height";
			this.nud_Height.Size = new System.Drawing.Size(120, 20);
			this.nud_Height.TabIndex = 8;
			this.nud_Height.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
			// 
			// ResizeUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(220, 144);
			this.Controls.Add(this.nud_Height);
			this.Controls.Add(this.nud_Width);
			this.Controls.Add(this.btn_Ok);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ResizeUI";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Resize Board";
			((System.ComponentModel.ISupportInitialize)(this.nud_Width)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Height)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_Ok;
		public System.Windows.Forms.NumericUpDown nud_Width;
		public System.Windows.Forms.NumericUpDown nud_Height;
	}
}