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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // event handler for George button
        private void georgeBioButton_Click(object sender, EventArgs e)
        {
            // declare and instantiate form for my button
            // pass my name using the button info; downcast and supply name
            Button tmpButton = (Button)sender;
            GeorgeBioForm georgeBio = new GeorgeBioForm(tmpButton.Text);

            // show the form
            georgeBio.Show();
        }
    }
}
