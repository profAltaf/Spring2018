namespace IC17
{
    partial class Form1
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
			this.altafBioButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.showJakeBioButton = new System.Windows.Forms.Button();
			this.showMartinBioButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// altafBioButton
			// 
			this.altafBioButton.Location = new System.Drawing.Point(568, 30);
			this.altafBioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.altafBioButton.Name = "altafBioButton";
			this.altafBioButton.Size = new System.Drawing.Size(145, 34);
			this.altafBioButton.TabIndex = 0;
			this.altafBioButton.Text = "Professor";
			this.altafBioButton.UseVisualStyleBackColor = true;
			this.altafBioButton.Click += new System.EventHandler(this.altafBioButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(592, 10);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Front of Class";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(592, 603);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Back of Class";
			// 
			// showJakeBioButton
			// 
			this.showJakeBioButton.Location = new System.Drawing.Point(1136, 369);
			this.showJakeBioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.showJakeBioButton.Name = "showJakeBioButton";
			this.showJakeBioButton.Size = new System.Drawing.Size(100, 28);
			this.showJakeBioButton.TabIndex = 2;
			this.showJakeBioButton.Text = "Jake";
			this.showJakeBioButton.UseVisualStyleBackColor = true;
			this.showJakeBioButton.Click += new System.EventHandler(this.showJakeBioButton_Click);
			// 
			// showMartinBioButton
			// 
			this.showMartinBioButton.Location = new System.Drawing.Point(921, 534);
			this.showMartinBioButton.Name = "showMartinBioButton";
			this.showMartinBioButton.Size = new System.Drawing.Size(75, 23);
			this.showMartinBioButton.TabIndex = 3;
			this.showMartinBioButton.Text = "Martin";
			this.showMartinBioButton.UseVisualStyleBackColor = true;
			this.showMartinBioButton.Click += new System.EventHandler(this.showMartinBioButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1345, 630);
			this.Controls.Add(this.showMartinBioButton);
			this.Controls.Add(this.showJakeBioButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.altafBioButton);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Launch Page - Click a Button to Launch a Student Bio";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button altafBioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showJakeBioButton;
		private System.Windows.Forms.Button showMartinBioButton;
	}
}

