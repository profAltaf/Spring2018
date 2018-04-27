namespace IC17
{
    partial class ChrisBioForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.dreamJobTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.dreamJobLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(289, 330);
            this.closeButton.Margin = new System.Windows.Forms.Padding(6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(410, 44);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // dreamJobTextBox
            // 
            this.dreamJobTextBox.Location = new System.Drawing.Point(161, 203);
            this.dreamJobTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.dreamJobTextBox.Multiline = true;
            this.dreamJobTextBox.Name = "dreamJobTextBox";
            this.dreamJobTextBox.Size = new System.Drawing.Size(642, 35);
            this.dreamJobTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(161, 76);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(642, 35);
            this.nameTextBox.TabIndex = 7;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(3, 219);
            this.Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(118, 25);
            this.Name.TabIndex = 6;
            this.Name.Text = "nameLabel";
            // 
            // dreamJobLabel
            // 
            this.dreamJobLabel.AutoSize = true;
            this.dreamJobLabel.Location = new System.Drawing.Point(-3, 76);
            this.dreamJobLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dreamJobLabel.Name = "dreamJobLabel";
            this.dreamJobLabel.Size = new System.Drawing.Size(116, 25);
            this.dreamJobLabel.TabIndex = 5;
            this.dreamJobLabel.Text = "Dream Job";
            // 
            // TeddyBioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 456);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dreamJobTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.dreamJobLabel);
            this.Name = "ChrisBioForm";
            this.Text = "ChrisBioForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox dreamJobTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label dreamJobLabel;
    }
}