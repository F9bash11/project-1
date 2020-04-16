using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //for stream object
using System.Reflection; // for assembly

namespace project_1
{
    public partial class FrmSelfiecs : Form
    {
        Assembly _assembly;
        Stream _imageStream;

        public FrmSelfiecs()
        {
            InitializeComponent();
            //controls the clipping and positioning of the image in the display area.
            PicSelfie.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CmbSelfie.Items.Add(TxtID.Text);
            TxtID.Text = null;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void CmbSelfie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbSelfie.Text == "1847318")
            {
                PicSelfie.Image = Image.FromStream(_imageStream);
            }
            else
            {
                PicSelfie.Image = null;
            }
        }

        private void FrmSelfiecs_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly();
            _imageStream = _assembly.GetManifestResourceStream("project_1.Resource.W.jpg");
        }
    }
}
