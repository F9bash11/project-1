namespace project_1
{
    partial class FrmPic01
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
            this.BtnLoadimage = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupPicture = new System.Windows.Forms.GroupBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.BtnImageFromResource = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.groupPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoadimage
            // 
            this.BtnLoadimage.Location = new System.Drawing.Point(16, 15);
            this.BtnLoadimage.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLoadimage.Name = "BtnLoadimage";
            this.BtnLoadimage.Size = new System.Drawing.Size(248, 60);
            this.BtnLoadimage.TabIndex = 0;
            this.BtnLoadimage.Text = "Load image";
            this.BtnLoadimage.UseVisualStyleBackColor = true;
            this.BtnLoadimage.Click += new System.EventHandler(this.BtnLoadimage_Click);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(67, 89);
            this.pic.Margin = new System.Windows.Forms.Padding(4);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(460, 245);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(1393, 487);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(156, 52);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // groupPicture
            // 
            this.groupPicture.Controls.Add(this.pic2);
            this.groupPicture.Controls.Add(this.pic);
            this.groupPicture.Location = new System.Drawing.Point(307, 66);
            this.groupPicture.Margin = new System.Windows.Forms.Padding(4);
            this.groupPicture.Name = "groupPicture";
            this.groupPicture.Padding = new System.Windows.Forms.Padding(4);
            this.groupPicture.Size = new System.Drawing.Size(1148, 414);
            this.groupPicture.TabIndex = 3;
            this.groupPicture.TabStop = false;
            this.groupPicture.Text = "Group Picture";
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(601, 89);
            this.pic2.Margin = new System.Windows.Forms.Padding(4);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(467, 245);
            this.pic2.TabIndex = 2;
            this.pic2.TabStop = false;
            this.pic2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnImageFromResource
            // 
            this.BtnImageFromResource.Location = new System.Drawing.Point(16, 122);
            this.BtnImageFromResource.Margin = new System.Windows.Forms.Padding(4);
            this.BtnImageFromResource.Name = "BtnImageFromResource";
            this.BtnImageFromResource.Size = new System.Drawing.Size(248, 66);
            this.BtnImageFromResource.TabIndex = 4;
            this.BtnImageFromResource.Text = "Image from Resource";
            this.BtnImageFromResource.UseVisualStyleBackColor = true;
            this.BtnImageFromResource.Click += new System.EventHandler(this.BtnImageFromResource_Click);
            // 
            // FrmPic01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1565, 554);
            this.Controls.Add(this.BtnImageFromResource);
            this.Controls.Add(this.groupPicture);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnLoadimage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPic01";
            this.Text = "FrmPic01";
            this.Load += new System.EventHandler(this.FrmPic01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.groupPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadimage;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.GroupBox groupPicture;
        private System.Windows.Forms.Button BtnImageFromResource;
        private System.Windows.Forms.PictureBox pic2;
    }
}