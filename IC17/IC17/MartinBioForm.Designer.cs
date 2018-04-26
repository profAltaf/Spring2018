namespace IC17
{
	partial class MartinBioForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.nameLabel = new System.Windows.Forms.Label();
			this.dreamJobLabel = new System.Windows.Forms.Label();
			this.dreamJobTextBox = new System.Windows.Forms.TextBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.closeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(39, 61);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(45, 17);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "Name";
			// 
			// dreamJobLabel
			// 
			this.dreamJobLabel.AutoSize = true;
			this.dreamJobLabel.Location = new System.Drawing.Point(39, 150);
			this.dreamJobLabel.Name = "dreamJobLabel";
			this.dreamJobLabel.Size = new System.Drawing.Size(77, 17);
			this.dreamJobLabel.TabIndex = 1;
			this.dreamJobLabel.Text = "Dream Job";
			// 
			// dreamJobTextBox
			// 
			this.dreamJobTextBox.Location = new System.Drawing.Point(202, 147);
			this.dreamJobTextBox.Name = "dreamJobTextBox";
			this.dreamJobTextBox.Size = new System.Drawing.Size(192, 22);
			this.dreamJobTextBox.TabIndex = 2;
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(202, 58);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(192, 22);
			this.nameTextBox.TabIndex = 3;
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(309, 295);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 4;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			// 
			// MartinBioForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 380);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.dreamJobTextBox);
			this.Controls.Add(this.dreamJobLabel);
			this.Controls.Add(this.nameLabel);
			this.Name = "MartinBioForm";
			this.Text = "MartinBioForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label dreamJobLabel;
		private System.Windows.Forms.TextBox dreamJobTextBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Button closeButton;
	}
}