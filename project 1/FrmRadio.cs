using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void RdoRed2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoRed2.Checked == true)
                RdoRed2.ForeColor = Color.FromArgb(255, 0, 0);
            else
                RdoRed2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoGreen2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoGreen2.Checked == true)
                RdoGreen2.ForeColor = Color.FromName("green"); // http://www.flounder.com/csharp_color_table.htm
            else
                RdoGreen2.ForeColor = Color.FromName("black");
        }

        private void RdoBlue2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoBlue2.Checked == true)
                RdoBlue2.ForeColor = Color.FromName("blue");
            else
                RdoBlue2.ForeColor = Color.FromName("black");
        }

        private void RdoYellow2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoYellow2.Checked == true)
                RdoYellow2.ForeColor = Color.FromName("yellow");
            else
                RdoYellow2.ForeColor = Color.FromName("black");
        }

        private void RdoRed_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoRed.Checked == true)
                RdoRed.ForeColor = Color.FromArgb(255, 0, 0);
            else
                RdoRed.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoGreen.Checked == true)
                RdoGreen.ForeColor = Color.FromName("green"); 
            else
                RdoGreen.ForeColor = Color.FromName("black");
        }

        private void RdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoBlue.Checked == true)
                RdoBlue.ForeColor = Color.FromName("blue");
            else
                RdoBlue.ForeColor = Color.FromName("black");
        }

        private void RdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoYellow.Checked == true)
                RdoYellow.ForeColor = Color.FromName("yellow");
            else
                RdoYellow.ForeColor = Color.FromName("black");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            RdoRed.Checked = false;
            RdoGreen.Checked = false;
            RdoBlue.Checked = false;
            RdoYellow.Checked = false;

            RdoRed.ForeColor = Color.FromName("black");
            RdoGreen.ForeColor = Color.FromName("black");
            RdoBlue.ForeColor = Color.FromName("black");
            RdoYellow.ForeColor = Color.FromName("black");

            RdoRed2.Checked = false;
            RdoGreen2.Checked = false;
            RdoBlue2.Checked = false;
            RdoYellow2.Checked = false;

            RdoRed2.ForeColor = Color.FromName("black");
            RdoGreen2.ForeColor = Color.FromName("black");
            RdoBlue2.ForeColor = Color.FromName("black");
            RdoYellow2.ForeColor = Color.FromName("black");
        }
    }
}
