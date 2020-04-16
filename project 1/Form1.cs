using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO; // for stream object
using System.Reflection; // for assembly

namespace project_1
{
    public partial class FrmMain : Form
    {
        Assembly _assembly;
        Stream _imageStream;

        string username = "Faisal";
        string myPassword = "1234";
        bool loggedIn = false;

        int attempt = 1;
        int MaxAttempts = 3;

        public FrmMain()
        {
            InitializeComponent();
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            FrmCombo frm = new FrmCombo();
            frm.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCheckBox_Click(object sender, EventArgs e)
        {
            FrmCheckBox frm = new FrmCheckBox();
            frm.ShowDialog();
        }

        public void BtnLogin_Click(object sender, EventArgs e)
        {
            if (! loggedIn)
            {
                while (attempt <= MaxAttempts)
                {
                    if (TxtPw.Text != myPassword && TxtUser.Text != username)
                    {
                        MessageBox.Show("Incorrect login," + (MaxAttempts - attempt) + " attempts remaining");
                        attempt++;
                        return;
                    }
                    else if (TxtUser.Text != username)
                    {
                        // username is incorrect
                        MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                        attempt++;
                        return;
                    }
                    else
                    {   // username is correct
                        // so check password			
                        if (TxtPw.Text != myPassword)
                        {
                            // Incorrect password
                            MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                            attempt++;
                            return;
                        }
                        else
                        {
                            //Both are correct
                            attempt = 1; // reset the number of attempts
                            MessageBox.Show("Login successful");
                            loggedIn = true;

                            BtnLogin.Text = "Logout";
                            // this.Width = 1600;
                            break; // come out of while loop
                        }//endif
                    }//endif
                }//end while
            }
            else
            {
                BtnLogin.Text = "Login";
                loggedIn = false;

                TxtUser.Clear();
                TxtPw.Clear();
            }
        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            FrmRadio frm = new FrmRadio();
            frm.ShowDialog();
        }


        private void BtnPictureBox_Click(object sender, EventArgs e)
        {
            FrmPic01 frm = new FrmPic01();
            frm.ShowDialog();
        }

        private void BtnPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BtnGroupieApp_Click(object sender, EventArgs e)
        {

        }

        private void BtnSelfieApp_Click(object sender, EventArgs e)
        {
            FrmSelfiecs frm = new FrmSelfiecs();
            frm.ShowDialog();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            FrmRandom frm = new FrmRandom();
            frm.ShowDialog();
        }

        private void BtnTimer_Click(object sender, EventArgs e)
        {

        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {

        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This project was developed throughout IE-322 course." +
                "\nBy: Faisal Bashmail." +
                "\nI hope you found it helpful as well as flexible." +
                "\n" +
                "\nIf you faced any problem, PLEASE inform me via email" +
                "\nHere is my email: fbashmail0001@stu.kau.edu.sa" +
                "\nThank you.");
        }

        private void BtnRandomCombo_Click(object sender, EventArgs e)
        {
            FrmRandomCombo frm = new FrmRandomCombo();
            frm.ShowDialog();
        }

        private void BtnArray_Click(object sender, EventArgs e)
        {
            frmArray frm = new frmArray();
            frm.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly();
            _imageStream = _assembly.GetManifestResourceStream("project_1.Resource.IE.jpg");
            try
            {
                picBox.Image = Image.FromStream(_imageStream);
            }
            catch
            {
                MessageBox.Show("Image file not found!");
            }
        }

        private void BtnMethod_Click(object sender, EventArgs e)
        {
            FrmMethod frm = new FrmMethod();
            frm.ShowDialog();
        }

        private void BtnCars_Click(object sender, EventArgs e)
        {
            FrmCars frm = new FrmCars();
            frm.ShowDialog();
        }
    }
}
