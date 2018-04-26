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
    public partial class BrockLefkowitzBioForm : Form
    {
        public BrockLefkowitzBioForm()
        {
            InitializeComponent();
        }

        private void BrockLefkowitzBioForm_Load(object sender, EventArgs e)
        {
            nameTextBox.ReadOnly = true;
            dreamJobTextBox.ReadOnly = true;
            //sets so name and oithers cant be edited
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //Closes this form
        }
    }
}
