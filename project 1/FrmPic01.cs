using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO; // for stream object
using System.Reflection; // for assembly

namespace project_1
{
    public partial class FrmPic01 : Form
    {
        Assembly _assembly;
        Stream _imageStream; // creating an imagestream 

        System.Drawing.Graphics graphicsObj3;
        Pen myPen = new Pen(System.Drawing.Color.White, 2);


        public FrmPic01()
        {
            InitializeComponent();
            //controls the clipping and positioning of the image in the display area.
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;

            graphicsObj3 = this.pic.CreateGraphics();
        }

        private void BtnLoadimage_Click(object sender, EventArgs e)
        {
            try
            {
                pic.Image = Image.FromFile("D:\\Faisal\\Backgrounds\\F9bash.jpg");

            }
            catch
            {
                MessageBox.Show("Image file not found!");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmPic01_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly();
            _imageStream = _assembly.GetManifestResourceStream("project_1.Resource.F.jpg");
        }

        private void BtnImageFromResource_Click(object sender, EventArgs e)
        {
            try
            {
                pic2.Image = Image.FromStream(_imageStream);
            }
            catch
            {
                MessageBox.Show("Image file not found!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pic_Click(object sender, EventArgs e)
        {
            Point coordinates = pic.PointToClient(Cursor.Position);   //relative to Panel control

            
            graphicsObj3.DrawLine(myPen, coordinates.X - 1, coordinates.Y - 1, coordinates.X, coordinates.Y);
            
            //MessageBox.Show("Coordinates are: " + coordinates);
        }
    }
}
