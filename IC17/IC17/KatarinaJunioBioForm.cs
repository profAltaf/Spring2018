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
    public partial class KatarinaJunioBioForm : Form
    {
        public KatarinaJunioBioForm()
        {
            InitializeComponent();
        }

        // will close form
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
