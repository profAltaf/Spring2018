// kylei chang, ic17, cis 345, tues/thurs 9am
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

        private void altafBioButton_Click(object sender, EventArgs e)
        {
            // declare and instantiate your form
            // show the form
            // WriteLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KyleiBioForm kyleiForm = new KyleiBioForm();

            kyleiForm.Show();
        }
    }
}
