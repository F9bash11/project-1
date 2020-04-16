namespace project_1
{
    partial class FrmCheckBox
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
            this.CheckCoffee = new System.Windows.Forms.CheckBox();
            this.CheckDonut = new System.Windows.Forms.CheckBox();
            this.CheckBrownie = new System.Windows.Forms.CheckBox();
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckCoffee
            // 
            this.CheckCoffee.AutoSize = true;
            this.CheckCoffee.Location = new System.Drawing.Point(356, 130);
            this.CheckCoffee.Margin = new System.Windows.Forms.Padding(4);
            this.CheckCoffee.Name = "CheckCoffee";
            this.CheckCoffee.Size = new System.Drawing.Size(71, 21);
            this.CheckCoffee.TabIndex = 0;
            this.CheckCoffee.Text = "Coffee";
            this.CheckCoffee.UseVisualStyleBackColor = true;
            // 
            // CheckDonut
            // 
            this.CheckDonut.AutoSize = true;
            this.CheckDonut.Location = new System.Drawing.Point(356, 229);
            this.CheckDonut.Margin = new System.Windows.Forms.Padding(4);
            this.CheckDonut.Name = "CheckDonut";
            this.CheckDonut.Size = new System.Drawing.Size(68, 21);
            this.CheckDonut.TabIndex = 1;
            this.CheckDonut.Text = "Donut";
            this.CheckDonut.UseVisualStyleBackColor = true;
            // 
            // CheckBrownie
            // 
            this.CheckBrownie.AutoSize = true;
            this.CheckBrownie.Location = new System.Drawing.Point(356, 324);
            this.CheckBrownie.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBrownie.Name = "CheckBrownie";
            this.CheckBrownie.Size = new System.Drawing.Size(80, 21);
            this.CheckBrownie.TabIndex = 2;
            this.CheckBrownie.Text = "Brownie";
            this.CheckBrownie.UseVisualStyleBackColor = true;
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(16, 15);
            this.BtnShow.Margin = new System.Windows.Forms.Padding(4);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(267, 62);
            this.BtnShow.TabIndex = 3;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(490, 479);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(267, 62);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrmCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(770, 554);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.CheckBrownie);
            this.Controls.Add(this.CheckDonut);
            this.Controls.Add(this.CheckCoffee);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCheckBox";
            this.Text = "FrmCheckBox";
            this.Load += new System.EventHandler(this.FrmCheckBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckCoffee;
        private System.Windows.Forms.CheckBox CheckDonut;
        private System.Windows.Forms.CheckBox CheckBrownie;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnBack;
    }
}