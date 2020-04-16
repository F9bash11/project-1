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
    public partial class FrmCheckBox : Form
    {
        public FrmCheckBox()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (CheckCoffee.Checked == true)
            {
                msg = CheckCoffee.Text;
            }

            if (CheckDonut.Checked == true)
            {
                msg = msg + " " + CheckDonut.Text;
            }

            if (CheckBrownie.Checked == true)
            {
                msg = msg + " " + CheckBrownie.Text;
            }

            if (msg.Length > 0)
            {
                MessageBox.Show(msg + " selected ");
            }
            else //length is zero
            {
                MessageBox.Show("Nothing selected");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void FrmCheckBox_Load(object sender, EventArgs e)
        {

        }
    }
}
