using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cringe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            pictureBoxControlsHelp.Visible = true;
        }
        private void resetPictures()
        {
            pictureBoxControlsHelp.Visible = false;
            pictureBoxSpectrometerHelp.Visible = false;
            pictureBoxFFTHelp.Visible = false;
            pictureBoxCalculationsHelp.Visible = false;
        }
        private void buttonControlHelp_Click(object sender, EventArgs e)
        {
            resetPictures();
            pictureBoxControlsHelp.Visible = true;
        }

        private void buttonSpectrometerHelp_Click(object sender, EventArgs e)
        {
            resetPictures();
            pictureBoxSpectrometerHelp.Visible = true;
        }

        private void buttonFFTHelp_Click(object sender, EventArgs e)
        {
            resetPictures();
            pictureBoxFFTHelp.Visible = true;
        }

        private void buttonCalculationsHelp_Click(object sender, EventArgs e)
        {
            resetPictures();
            pictureBoxCalculationsHelp.Visible = true;
        }
    }
}
