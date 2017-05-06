namespace SudokuSolver_Try1 {
	partial class ConfirmationUI {
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
			this.lb_MessageContents = new System.Windows.Forms.Label();
			this.btn_Option1 = new System.Windows.Forms.Button();
			this.btn_Option2 = new System.Windows.Forms.Button();
			this.btn_Option3 = new System.Windows.Forms.Button();
			this.tlp_ButtonContainer = new System.Windows.Forms.TableLayoutPanel();
			this.tlp_ButtonContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// lb_MessageContents
			// 
			this.lb_MessageContents.AutoSize = true;
			this.lb_MessageContents.Location = new System.Drawing.Point(13, 13);
			this.lb_MessageContents.Name = "lb_MessageContents";
			this.lb_MessageContents.Size = new System.Drawing.Size(49, 13);
			this.lb_MessageContents.TabIndex = 0;
			this.lb_MessageContents.Text = "Contents";
			// 
			// btn_Option1
			// 
			this.btn_Option1.DialogResult = System.Windows.Forms.DialogResult.No;
			this.btn_Option1.Location = new System.Drawing.Point(3, 3);
			this.btn_Option1.Name = "btn_Option1";
			this.btn_Option1.Size = new System.Drawing.Size(75, 23);
			this.btn_Option1.TabIndex = 1;
			this.btn_Option1.Text = "No";
			this.btn_Option1.UseVisualStyleBackColor = true;
			// 
			// btn_Option2
			// 
			this.btn_Option2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Option2.Location = new System.Drawing.Point(84, 3);
			this.btn_Option2.Name = "btn_Option2";
			this.btn_Option2.Size = new System.Drawing.Size(75, 23);
			this.btn_Option2.TabIndex = 2;
			this.btn_Option2.Text = "Cancel";
			this.btn_Option2.UseVisualStyleBackColor = true;
			// 
			// btn_Option3
			// 
			this.btn_Option3.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.btn_Option3.Location = new System.Drawing.Point(165, 3);
			this.btn_Option3.Name = "btn_Option3";
			this.btn_Option3.Size = new System.Drawing.Size(75, 23);
			this.btn_Option3.TabIndex = 3;
			this.btn_Option3.Text = "Yes";
			this.btn_Option3.UseVisualStyleBackColor = true;
			// 
			// tlp_ButtonContainer
			// 
			this.tlp_ButtonContainer.AutoSize = true;
			this.tlp_ButtonContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tlp_ButtonContainer.ColumnCount = 3;
			this.tlp_ButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlp_ButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlp_ButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlp_ButtonContainer.Controls.Add(this.btn_Option1, 0, 0);
			this.tlp_ButtonContainer.Controls.Add(this.btn_Option2, 1, 0);
			this.tlp_ButtonContainer.Controls.Add(this.btn_Option3, 2, 0);
			this.tlp_ButtonContainer.Location = new System.Drawing.Point(12, 70);
			this.tlp_ButtonContainer.Name = "tlp_ButtonContainer";
			this.tlp_ButtonContainer.RowCount = 1;
			this.tlp_ButtonContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlp_ButtonContainer.Size = new System.Drawing.Size(243, 29);
			this.tlp_ButtonContainer.TabIndex = 4;
			// 
			// ConfirmationUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(261, 115);
			this.Controls.Add(this.tlp_ButtonContainer);
			this.Controls.Add(this.lb_MessageContents);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConfirmationUI";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "ConfirmationUI";
			this.tlp_ButtonContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_MessageContents;
		private System.Windows.Forms.Button btn_Option1;
		private System.Windows.Forms.Button btn_Option2;
		private System.Windows.Forms.Button btn_Option3;
		private System.Windows.Forms.TableLayoutPanel tlp_ButtonContainer;
	}
}