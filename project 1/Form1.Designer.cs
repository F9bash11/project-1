namespace project_1
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtPw = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnRadio = new System.Windows.Forms.Button();
            this.BtnCheckBox = new System.Windows.Forms.Button();
            this.BtnCombo = new System.Windows.Forms.Button();
            this.BtnPictureBox = new System.Windows.Forms.Button();
            this.Arduino = new System.Windows.Forms.Button();
            this.BtnPictureBox2 = new System.Windows.Forms.Button();
            this.BtnSelfieApp = new System.Windows.Forms.Button();
            this.BtnGroupieApp = new System.Windows.Forms.Button();
            this.BtnProgress = new System.Windows.Forms.Button();
            this.BtnTimer = new System.Windows.Forms.Button();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.BtnTalk = new System.Windows.Forms.Button();
            this.BtnRoboticCell = new System.Windows.Forms.Button();
            this.BtnJohari = new System.Windows.Forms.Button();
            this.BtnABCAnalysis = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnMethod = new System.Windows.Forms.Button();
            this.BtnArray = new System.Windows.Forms.Button();
            this.BtnRandomCombo = new System.Windows.Forms.Button();
            this.BtnManufacturingCell = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.BtnCars = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtPw);
            this.groupBox1.Controls.Add(this.TxtUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnLogin);
            this.groupBox1.Controls.Add(this.BtnExit);
            this.groupBox1.Location = new System.Drawing.Point(24, 160);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(351, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login to IE322";
            // 
            // TxtPw
            // 
            this.TxtPw.Location = new System.Drawing.Point(131, 150);
            this.TxtPw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPw.Name = "TxtPw";
            this.TxtPw.Size = new System.Drawing.Size(193, 22);
            this.TxtPw.TabIndex = 3;
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(131, 62);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(193, 22);
            this.TxtUser.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnLogin.ForeColor = System.Drawing.Color.Black;
            this.BtnLogin.Location = new System.Drawing.Point(9, 235);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(140, 46);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.ForeColor = System.Drawing.Color.Black;
            this.BtnExit.Location = new System.Drawing.Point(184, 235);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(140, 46);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnRadio
            // 
            this.BtnRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnRadio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnRadio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnRadio.Location = new System.Drawing.Point(27, 41);
            this.BtnRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRadio.Name = "BtnRadio";
            this.BtnRadio.Size = new System.Drawing.Size(149, 39);
            this.BtnRadio.TabIndex = 4;
            this.BtnRadio.Text = "Radio";
            this.BtnRadio.UseVisualStyleBackColor = false;
            this.BtnRadio.Click += new System.EventHandler(this.BtnRadio_Click);
            // 
            // BtnCheckBox
            // 
            this.BtnCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCheckBox.Location = new System.Drawing.Point(27, 123);
            this.BtnCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCheckBox.Name = "BtnCheckBox";
            this.BtnCheckBox.Size = new System.Drawing.Size(149, 39);
            this.BtnCheckBox.TabIndex = 5;
            this.BtnCheckBox.Text = "CheckBox";
            this.BtnCheckBox.UseVisualStyleBackColor = false;
            this.BtnCheckBox.Click += new System.EventHandler(this.BtnCheckBox_Click);
            // 
            // BtnCombo
            // 
            this.BtnCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCombo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCombo.Location = new System.Drawing.Point(225, 123);
            this.BtnCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCombo.Name = "BtnCombo";
            this.BtnCombo.Size = new System.Drawing.Size(149, 39);
            this.BtnCombo.TabIndex = 6;
            this.BtnCombo.Text = "Combo";
            this.BtnCombo.UseVisualStyleBackColor = false;
            this.BtnCombo.Click += new System.EventHandler(this.BtnCombo_Click);
            // 
            // BtnPictureBox
            // 
            this.BtnPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnPictureBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnPictureBox.Location = new System.Drawing.Point(27, 202);
            this.BtnPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPictureBox.Name = "BtnPictureBox";
            this.BtnPictureBox.Size = new System.Drawing.Size(149, 39);
            this.BtnPictureBox.TabIndex = 7;
            this.BtnPictureBox.Text = "PictureBox";
            this.BtnPictureBox.UseVisualStyleBackColor = false;
            this.BtnPictureBox.Click += new System.EventHandler(this.BtnPictureBox_Click);
            // 
            // Arduino
            // 
            this.Arduino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Arduino.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Arduino.Location = new System.Drawing.Point(831, 278);
            this.Arduino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Arduino.Name = "Arduino";
            this.Arduino.Size = new System.Drawing.Size(200, 50);
            this.Arduino.TabIndex = 8;
            this.Arduino.Text = "Arduino";
            this.Arduino.UseVisualStyleBackColor = false;
            // 
            // BtnPictureBox2
            // 
            this.BtnPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnPictureBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnPictureBox2.Location = new System.Drawing.Point(225, 41);
            this.BtnPictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPictureBox2.Name = "BtnPictureBox2";
            this.BtnPictureBox2.Size = new System.Drawing.Size(149, 39);
            this.BtnPictureBox2.TabIndex = 9;
            this.BtnPictureBox2.Text = "PictureBox2";
            this.BtnPictureBox2.UseVisualStyleBackColor = false;
            this.BtnPictureBox2.Click += new System.EventHandler(this.BtnPictureBox2_Click);
            // 
            // BtnSelfieApp
            // 
            this.BtnSelfieApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnSelfieApp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSelfieApp.Location = new System.Drawing.Point(27, 284);
            this.BtnSelfieApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSelfieApp.Name = "BtnSelfieApp";
            this.BtnSelfieApp.Size = new System.Drawing.Size(149, 39);
            this.BtnSelfieApp.TabIndex = 10;
            this.BtnSelfieApp.Text = "SelfieApp";
            this.BtnSelfieApp.UseVisualStyleBackColor = false;
            this.BtnSelfieApp.Click += new System.EventHandler(this.BtnSelfieApp_Click);
            // 
            // BtnGroupieApp
            // 
            this.BtnGroupieApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnGroupieApp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGroupieApp.Location = new System.Drawing.Point(225, 202);
            this.BtnGroupieApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGroupieApp.Name = "BtnGroupieApp";
            this.BtnGroupieApp.Size = new System.Drawing.Size(149, 39);
            this.BtnGroupieApp.TabIndex = 11;
            this.BtnGroupieApp.Text = "GroupieApp";
            this.BtnGroupieApp.UseVisualStyleBackColor = false;
            this.BtnGroupieApp.Click += new System.EventHandler(this.BtnGroupieApp_Click);
            // 
            // BtnProgress
            // 
            this.BtnProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnProgress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnProgress.Location = new System.Drawing.Point(225, 284);
            this.BtnProgress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnProgress.Name = "BtnProgress";
            this.BtnProgress.Size = new System.Drawing.Size(149, 39);
            this.BtnProgress.TabIndex = 12;
            this.BtnProgress.Text = "Progress";
            this.BtnProgress.UseVisualStyleBackColor = false;
            // 
            // BtnTimer
            // 
            this.BtnTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnTimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnTimer.Location = new System.Drawing.Point(424, 202);
            this.BtnTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnTimer.Name = "BtnTimer";
            this.BtnTimer.Size = new System.Drawing.Size(149, 39);
            this.BtnTimer.TabIndex = 13;
            this.BtnTimer.Text = "Timer";
            this.BtnTimer.UseVisualStyleBackColor = false;
            this.BtnTimer.Click += new System.EventHandler(this.BtnTimer_Click);
            // 
            // BtnRandom
            // 
            this.BtnRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnRandom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnRandom.Location = new System.Drawing.Point(424, 123);
            this.BtnRandom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(149, 39);
            this.BtnRandom.TabIndex = 14;
            this.BtnRandom.Text = "Random";
            this.BtnRandom.UseVisualStyleBackColor = false;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // BtnDraw
            // 
            this.BtnDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnDraw.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDraw.Location = new System.Drawing.Point(424, 41);
            this.BtnDraw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(149, 39);
            this.BtnDraw.TabIndex = 16;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.UseVisualStyleBackColor = false;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // BtnTalk
            // 
            this.BtnTalk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnTalk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnTalk.Location = new System.Drawing.Point(424, 284);
            this.BtnTalk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnTalk.Name = "BtnTalk";
            this.BtnTalk.Size = new System.Drawing.Size(149, 39);
            this.BtnTalk.TabIndex = 17;
            this.BtnTalk.Text = "Talk";
            this.BtnTalk.UseVisualStyleBackColor = false;
            // 
            // BtnRoboticCell
            // 
            this.BtnRoboticCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnRoboticCell.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnRoboticCell.Location = new System.Drawing.Point(831, 200);
            this.BtnRoboticCell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRoboticCell.Name = "BtnRoboticCell";
            this.BtnRoboticCell.Size = new System.Drawing.Size(200, 50);
            this.BtnRoboticCell.TabIndex = 19;
            this.BtnRoboticCell.Text = "Robotic Cell";
            this.BtnRoboticCell.UseVisualStyleBackColor = false;
            // 
            // BtnJohari
            // 
            this.BtnJohari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnJohari.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnJohari.Location = new System.Drawing.Point(605, 200);
            this.BtnJohari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnJohari.Name = "BtnJohari";
            this.BtnJohari.Size = new System.Drawing.Size(200, 50);
            this.BtnJohari.TabIndex = 20;
            this.BtnJohari.Text = "Johari";
            this.BtnJohari.UseVisualStyleBackColor = false;
            // 
            // BtnABCAnalysis
            // 
            this.BtnABCAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnABCAnalysis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnABCAnalysis.Location = new System.Drawing.Point(605, 117);
            this.BtnABCAnalysis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnABCAnalysis.Name = "BtnABCAnalysis";
            this.BtnABCAnalysis.Size = new System.Drawing.Size(200, 50);
            this.BtnABCAnalysis.TabIndex = 21;
            this.BtnABCAnalysis.Text = "ABC Analysis";
            this.BtnABCAnalysis.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCars);
            this.groupBox2.Controls.Add(this.BtnMethod);
            this.groupBox2.Controls.Add(this.BtnArray);
            this.groupBox2.Controls.Add(this.BtnRandomCombo);
            this.groupBox2.Controls.Add(this.BtnManufacturingCell);
            this.groupBox2.Controls.Add(this.BtnJohari);
            this.groupBox2.Controls.Add(this.BtnTalk);
            this.groupBox2.Controls.Add(this.BtnABCAnalysis);
            this.groupBox2.Controls.Add(this.BtnPictureBox2);
            this.groupBox2.Controls.Add(this.BtnDraw);
            this.groupBox2.Controls.Add(this.BtnSelfieApp);
            this.groupBox2.Controls.Add(this.BtnProgress);
            this.groupBox2.Controls.Add(this.BtnRadio);
            this.groupBox2.Controls.Add(this.BtnTimer);
            this.groupBox2.Controls.Add(this.BtnRoboticCell);
            this.groupBox2.Controls.Add(this.BtnCheckBox);
            this.groupBox2.Controls.Add(this.BtnRandom);
            this.groupBox2.Controls.Add(this.BtnCombo);
            this.groupBox2.Controls.Add(this.BtnGroupieApp);
            this.groupBox2.Controls.Add(this.BtnPictureBox);
            this.groupBox2.Controls.Add(this.Arduino);
            this.groupBox2.Location = new System.Drawing.Point(411, 34);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1048, 435);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // BtnMethod
            // 
            this.BtnMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnMethod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMethod.Location = new System.Drawing.Point(424, 358);
            this.BtnMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMethod.Name = "BtnMethod";
            this.BtnMethod.Size = new System.Drawing.Size(149, 39);
            this.BtnMethod.TabIndex = 25;
            this.BtnMethod.Text = "Method";
            this.BtnMethod.UseVisualStyleBackColor = false;
            this.BtnMethod.Click += new System.EventHandler(this.BtnMethod_Click);
            // 
            // BtnArray
            // 
            this.BtnArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnArray.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnArray.Location = new System.Drawing.Point(27, 358);
            this.BtnArray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnArray.Name = "BtnArray";
            this.BtnArray.Size = new System.Drawing.Size(149, 39);
            this.BtnArray.TabIndex = 24;
            this.BtnArray.Text = "Array";
            this.BtnArray.UseVisualStyleBackColor = false;
            this.BtnArray.Click += new System.EventHandler(this.BtnArray_Click);
            // 
            // BtnRandomCombo
            // 
            this.BtnRandomCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnRandomCombo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnRandomCombo.Location = new System.Drawing.Point(605, 278);
            this.BtnRandomCombo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRandomCombo.Name = "BtnRandomCombo";
            this.BtnRandomCombo.Size = new System.Drawing.Size(200, 50);
            this.BtnRandomCombo.TabIndex = 23;
            this.BtnRandomCombo.Text = "Random Combo";
            this.BtnRandomCombo.UseVisualStyleBackColor = false;
            this.BtnRandomCombo.Click += new System.EventHandler(this.BtnRandomCombo_Click);
            // 
            // BtnManufacturingCell
            // 
            this.BtnManufacturingCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnManufacturingCell.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnManufacturingCell.Location = new System.Drawing.Point(831, 117);
            this.BtnManufacturingCell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnManufacturingCell.Name = "BtnManufacturingCell";
            this.BtnManufacturingCell.Size = new System.Drawing.Size(200, 50);
            this.BtnManufacturingCell.TabIndex = 22;
            this.BtnManufacturingCell.Text = "Manufacturing Cell";
            this.BtnManufacturingCell.UseVisualStyleBackColor = false;
            // 
            // BtnAbout
            // 
            this.BtnAbout.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAbout.Location = new System.Drawing.Point(1295, 499);
            this.BtnAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(164, 39);
            this.BtnAbout.TabIndex = 23;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = false;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(24, 4);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(149, 130);
            this.picBox.TabIndex = 24;
            this.picBox.TabStop = false;
            // 
            // BtnCars
            // 
            this.BtnCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCars.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCars.Location = new System.Drawing.Point(225, 358);
            this.BtnCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCars.Name = "BtnCars";
            this.BtnCars.Size = new System.Drawing.Size(149, 39);
            this.BtnCars.TabIndex = 26;
            this.BtnCars.Text = "Cars";
            this.BtnCars.UseVisualStyleBackColor = false;
            this.BtnCars.Click += new System.EventHandler(this.BtnCars_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1469, 547);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.Text = "IE322_S20_KAU";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPw;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnRadio;
        private System.Windows.Forms.Button BtnCheckBox;
        private System.Windows.Forms.Button BtnCombo;
        private System.Windows.Forms.Button BtnPictureBox;
        private System.Windows.Forms.Button Arduino;
        private System.Windows.Forms.Button BtnPictureBox2;
        private System.Windows.Forms.Button BtnSelfieApp;
        private System.Windows.Forms.Button BtnGroupieApp;
        private System.Windows.Forms.Button BtnProgress;
        private System.Windows.Forms.Button BtnTimer;
        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.Button BtnTalk;
        private System.Windows.Forms.Button BtnRoboticCell;
        private System.Windows.Forms.Button BtnJohari;
        private System.Windows.Forms.Button BtnABCAnalysis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnManufacturingCell;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Button BtnRandomCombo;
        private System.Windows.Forms.Button BtnArray;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button BtnMethod;
        private System.Windows.Forms.Button BtnCars;
    }
}

