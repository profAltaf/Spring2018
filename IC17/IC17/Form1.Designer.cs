//Noel Hernandez, cis 345 TTH 9:00am, IC17
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
            this.showTannerMillyardBioButton = new System.Windows.Forms.Button();
            this.showLeynesBioButton = new System.Windows.Forms.Button();
            this.showNoelBioButtton = new System.Windows.Forms.Button();
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
            // showJakeBioButton
            // 
            this.showJakeBioButton.Location = new System.Drawing.Point(0, 0);
            this.showJakeBioButton.Name = "showJakeBioButton";
            this.showJakeBioButton.Size = new System.Drawing.Size(75, 23);
            this.showJakeBioButton.TabIndex = 0;
            // 
            // showTannerMillyardBioButton
            // 
            this.showTannerMillyardBioButton.Location = new System.Drawing.Point(0, 0);
            this.showTannerMillyardBioButton.Name = "showTannerMillyardBioButton";
            this.showTannerMillyardBioButton.Size = new System.Drawing.Size(75, 23);
            this.showTannerMillyardBioButton.TabIndex = 0;
            // 
            // showLeynesBioButton
            // 
            this.showLeynesBioButton.Location = new System.Drawing.Point(674, 134);
            this.showLeynesBioButton.Name = "showLeynesBioButton";
            this.showLeynesBioButton.Size = new System.Drawing.Size(75, 23);
            this.showLeynesBioButton.TabIndex = 2;
            this.showLeynesBioButton.Text = "Jeremiah";
            this.showLeynesBioButton.UseVisualStyleBackColor = true;
            this.showLeynesBioButton.Click += new System.EventHandler(this.showLeynesBioButton_Click);
            // 
            // showNoelBioButtton
            // 
            this.showNoelBioButtton.Location = new System.Drawing.Point(242, 414);
            this.showNoelBioButtton.Name = "showNoelBioButtton";
            this.showNoelBioButtton.Size = new System.Drawing.Size(75, 23);
            this.showNoelBioButtton.TabIndex = 3;
            this.showNoelBioButtton.Text = "Noel";
            this.showNoelBioButtton.UseVisualStyleBackColor = true;
            this.showNoelBioButtton.Click += new System.EventHandler(this.showNoelBioButtton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 512);
            this.Controls.Add(this.showNoelBioButtton);
            this.Controls.Add(this.showLeynesBioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.altafBioButton);
            this.Name = "Form1";
            this.Text = "Launch Page - Click a Button to Launch a Student Bio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button altafBioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showLeynesBioButton;
        private System.Windows.Forms.Button showTannerMillyardBioButton;
        private System.Windows.Forms.Button showJakeBioButton;
        private System.Windows.Forms.Button showNoelBioButtton;
    }
}

