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
            this.SuspendLayout();
            // 
            // showJiawangBioButton
            // 
            this.altafBioButton.Location = new System.Drawing.Point(852, 46);
            this.altafBioButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.altafBioButton.Name = "altafBioButton";
            this.altafBioButton.Size = new System.Drawing.Size(218, 54);
            this.altafBioButton.TabIndex = 0;
            this.altafBioButton.Text = "Professor";
            this.altafBioButton.UseVisualStyleBackColor = true;
            this.altafBioButton.Click += new System.EventHandler(this.altafBioButton_Click);
            // 
            // label1
            this.showJiawangBioButton.Location = new System.Drawing.Point(175, 86);
            this.showJiawangBioButton.Name = "showJiawangBioButton";
            this.showJiawangBioButton.Size = new System.Drawing.Size(75, 23);
            this.showJiawangBioButton.TabIndex = 0;
            this.showJiawangBioButton.Text = "Jiawang";
            this.showJiawangBioButton.UseVisualStyleBackColor = true;
            this.showJiawangBioButton.Click += new System.EventHandler(this.showJiawangBioButton_Click);
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(888, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Front of Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(888, 942);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Back of Class";
            // 
            // showChrisBioButton
            // 
            this.showChrisBioButton.Location = new System.Drawing.Point(1096, 46);
            this.showChrisBioButton.Margin = new System.Windows.Forms.Padding(6);
            this.showChrisBioButton.Name = "showChrisBioButton";
            this.showChrisBioButton.Size = new System.Drawing.Size(234, 44);
            this.showChrisBioButton.TabIndex = 2;
            this.showChrisBioButton.Text = "Chris";
            this.showChrisBioButton.UseVisualStyleBackColor = true;
            this.showChrisBioButton.Click += new System.EventHandler(this.showChrisBioButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(473, 363);
            this.Controls.Add(this.showJiawangBioButton);
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2018, 985);
            this.Controls.Add(this.showChrisBioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.altafBioButton);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button altafBioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showJiawangBioButton;
        private System.Windows.Forms.Button showChrisBioButton;
    }
}

