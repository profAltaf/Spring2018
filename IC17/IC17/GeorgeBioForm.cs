using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IC17
{
    public partial class GeorgeBioForm : Form
    {
        public GeorgeBioForm()
        {
            InitializeComponent();
        }

        // store my name
        private string name;

        // overloaded constructor to get my name from button
        public GeorgeBioForm(string name)
        {
            InitializeComponent();

            // save my name in the field
            this.name = name;

            // fill in text boxes
            nameTextBox.Text = $"{name} Heiler";
            dreamJobTextBox.Text = "Self-Employed Investor";
        }

        // exit button event handler
        private void exitButton_Click(object sender, EventArgs e)
        {
            // close my form
            this.Close();
        }
    }
}
