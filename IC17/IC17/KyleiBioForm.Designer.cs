namespace IC17
{
    partial class KyleiBioForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dreamJobTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(74, 67);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "nameLabel";
            // 
            // dreamJobLabel
            // 
            this.dreamJobLabel.AutoSize = true;
            this.dreamJobLabel.Location = new System.Drawing.Point(77, 122);
            this.dreamJobLabel.Name = "dreamJobLabel";
            this.dreamJobLabel.Size = new System.Drawing.Size(35, 13);
            this.dreamJobLabel.TabIndex = 1;
            this.dreamJobLabel.Text = "label2";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(161, 67);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // dreamJobTextBox
            // 
            this.dreamJobTextBox.Location = new System.Drawing.Point(161, 122);
            this.dreamJobTextBox.Name = "dreamJobTextBox";
            this.dreamJobTextBox.Size = new System.Drawing.Size(100, 20);
            this.dreamJobTextBox.TabIndex = 3;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(161, 183);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // KyleiBioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dreamJobTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.dreamJobLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "KyleiBioForm";
            this.Text = "KyleiBioForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dreamJobLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox dreamJobTextBox;
        private System.Windows.Forms.Button closeButton;
    }
}