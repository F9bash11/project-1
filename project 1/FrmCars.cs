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
    public partial class FrmCars : Form
    {
        Car MyCar = new Car();
        Car HisCar = new Car();

        public FrmCars()
        {
            InitializeComponent();
        }

        private void btnStartMyCar_Click(object sender, EventArgs e)
        {
            MyCar.Start();
        }

        private void btnStartHisCar_Click(object sender, EventArgs e)
        {
            HisCar.Start();
        }

        private void btnAccelerateMyCar_Click(object sender, EventArgs e)
        {
            MyCar.Accelerate(50);
        }

        private void btnAccelerateHisCar_Click(object sender, EventArgs e)
        {
            HisCar.Accelerate(80);
        }

        private void btnStopMyCar_Click(object sender, EventArgs e)
        {
            MyCar.Stop();
        }

        private void btnStopHisCar_Click(object sender, EventArgs e)
        {
            HisCar.Stop();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
