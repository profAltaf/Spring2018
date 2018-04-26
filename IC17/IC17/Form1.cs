//Brock Lefkowitz, CIS345, 9:00 am
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

        private void brockLefkowitzBioButton_Click(object sender, EventArgs e)
        {
            BrockLefkowitzBioForm brockLefkowitzBioForm = new BrockLefkowitzBioForm();
            brockLefkowitzBioForm.Show();
            //instantiates a new instance of my bio form and shows it
        }
    }
}
