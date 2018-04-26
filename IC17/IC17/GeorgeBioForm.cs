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
        }
    }
}
