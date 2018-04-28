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
            this.showChrisBioButton = new System.Windows.Forms.Button();
            this.showJiawangBioButton = new System.Windows.Forms.Button();
            this.showThomasBioButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // altafBioButton
            // 
            this.altafBioButton.Location = new System.Drawing.Point(426, 24);
            this.altafBioButton.Name = "altafBioButton";
            this.altafBioButton.Size = new System.Drawing.Size(109, 28);
            this.altafBioButton.TabIndex = 0;
            this.altafBioButton.Text = "Professor";
            this.altafBioButton.UseVisualStyleBackColor = true;
            this.altafBioButton.Click += new System.EventHandler(this.altafBioButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Front of Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Back of Class";
            // 
            // showChrisBioButton
            // 
            this.showChrisBioButton.Location = new System.Drawing.Point(548, 24);
            this.showChrisBioButton.Name = "showChrisBioButton";
            this.showChrisBioButton.Size = new System.Drawing.Size(117, 23);
            this.showChrisBioButton.TabIndex = 2;
            this.showChrisBioButton.Text = "Chris";
            this.showChrisBioButton.UseVisualStyleBackColor = true;
            this.showChrisBioButton.Click += new System.EventHandler(this.showChrisBioButton_Click);
            // 
            // showJiawangBioButton
            // 
            this.showJiawangBioButton.Location = new System.Drawing.Point(88, 45);
            this.showJiawangBioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showJiawangBioButton.Name = "showJiawangBioButton";
            this.showJiawangBioButton.Size = new System.Drawing.Size(38, 12);
            this.showJiawangBioButton.TabIndex = 0;
            this.showJiawangBioButton.Text = "Jiawang";
            this.showJiawangBioButton.UseVisualStyleBackColor = true;
            this.showJiawangBioButton.Click += new System.EventHandler(this.showJiawangBioButton_Click);
            // 
            // showThomasBioButton
            // 
            this.showThomasBioButton.Location = new System.Drawing.Point(88, 159);
            this.showThomasBioButton.Name = "showThomasBioButton";
            this.showThomasBioButton.Size = new System.Drawing.Size(75, 23);
            this.showThomasBioButton.TabIndex = 3;
            this.showThomasBioButton.Text = "button1";
            this.showThomasBioButton.UseVisualStyleBackColor = true;
            this.showThomasBioButton.Click += new System.EventHandler(this.showThomasBioButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.showThomasBioButton);
            this.Controls.Add(this.showJiawangBioButton);
            this.Controls.Add(this.showChrisBioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.altafBioButton);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button altafBioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showJiawangBioButton;
        private System.Windows.Forms.Button showChrisBioButton;
        private System.Windows.Forms.Button showThomasBioButton;
    }
}

