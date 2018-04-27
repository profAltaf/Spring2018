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
        ChrisBioForm chrisBioForm;

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

        private void showAlfredBioButton_Click(object sender, EventArgs e)
        {
            AlfredBioForm alfredBioForm = new AlfredBioForm();
            alfredBioForm.Show();
        }

        private void showLeynesBioButton_Click(object sender, EventArgs e)
        {
            LeynesBioForm leynesBioForm = new LeynesBioForm();
            leynesBioForm.Show();
        }

        private void showTannerMillyardBioButton_Click(object sender, EventArgs e)
        {
            TannerMillyardBioForm tannerMillyardBioShow = new TannerMillyardBioForm();
            tannerMillyardBioShow.Show();
        }

        private void showJakeBioButton_Click(object sender, EventArgs e)
        {
            JakeBioForm jakeBioForm = new JakeBioForm();

            jakeBioForm.Show();
        }

        private void showChrisBioButton_Click(object sender, EventArgs e)
        {
            chrisBioForm = new ChrisBioForm();
            chrisBioForm.Show();
        }
    }
}
