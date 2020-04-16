namespace project_1
{
    partial class FrmSelfiecs
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.CmbSelfie = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PicSelfie = new System.Windows.Forms.PictureBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSelfie)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(1070, 388);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(150, 50);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 143);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(200, 50);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CmbSelfie
            // 
            this.CmbSelfie.FormattingEnabled = true;
            this.CmbSelfie.Location = new System.Drawing.Point(275, 83);
            this.CmbSelfie.Name = "CmbSelfie";
            this.CmbSelfie.Size = new System.Drawing.Size(221, 24);
            this.CmbSelfie.TabIndex = 2;
            this.CmbSelfie.SelectedIndexChanged += new System.EventHandler(this.CmbSelfie_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PicSelfie);
            this.groupBox1.Location = new System.Drawing.Point(514, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 341);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picture ";
            // 
            // PicSelfie
            // 
            this.PicSelfie.Location = new System.Drawing.Point(22, 36);
            this.PicSelfie.Name = "PicSelfie";
            this.PicSelfie.Size = new System.Drawing.Size(633, 287);
            this.PicSelfie.TabIndex = 0;
            this.PicSelfie.TabStop = false;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(12, 85);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(200, 22);
            this.TxtID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter your ID";
            // 
            // FrmSelfiecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1232, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.CmbSelfie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnBack);
            this.Name = "FrmSelfiecs";
            this.Text = "FrmSelfiecs";
            this.Load += new System.EventHandler(this.FrmSelfiecs_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicSelfie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ComboBox CmbSelfie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PicSelfie;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label1;
    }
}