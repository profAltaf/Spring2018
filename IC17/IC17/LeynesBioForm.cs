//IC17, Jeremiah Leynes, CIS 345
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
    public partial class LeynesBioForm : Form
    {
        public LeynesBioForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
