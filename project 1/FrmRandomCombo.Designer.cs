namespace project_1
{
    partial class FrmRandomCombo
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
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.CmbRandom = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdoLess = new System.Windows.Forms.RadioButton();
            this.RdoGreater = new System.Windows.Forms.RadioButton();
            this.BtnReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoLess2 = new System.Windows.Forms.RadioButton();
            this.rdoGreater2 = new System.Windows.Forms.RadioButton();
            this.BtnGenerate2 = new System.Windows.Forms.Button();
            this.BtnReset2 = new System.Windows.Forms.Button();
            this.CmbRandom2 = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(293, 28);
            this.BtnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(267, 62);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // CmbRandom
            // 
            this.CmbRandom.FormattingEnabled = true;
            this.CmbRandom.Location = new System.Drawing.Point(8, 48);
            this.CmbRandom.Margin = new System.Windows.Forms.Padding(4);
            this.CmbRandom.Name = "CmbRandom";
            this.CmbRandom.Size = new System.Drawing.Size(245, 24);
            this.CmbRandom.TabIndex = 1;
            this.CmbRandom.SelectedIndexChanged += new System.EventHandler(this.CmbRandom_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdoLess);
            this.groupBox1.Controls.Add(this.RdoGreater);
            this.groupBox1.Controls.Add(this.BtnReset);
            this.groupBox1.Controls.Add(this.BtnGenerate);
            this.groupBox1.Controls.Add(this.CmbRandom);
            this.groupBox1.Location = new System.Drawing.Point(30, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(580, 309);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group 1";
            // 
            // RdoLess
            // 
            this.RdoLess.AutoSize = true;
            this.RdoLess.Location = new System.Drawing.Point(37, 223);
            this.RdoLess.Margin = new System.Windows.Forms.Padding(4);
            this.RdoLess.Name = "RdoLess";
            this.RdoLess.Size = new System.Drawing.Size(59, 21);
            this.RdoLess.TabIndex = 4;
            this.RdoLess.TabStop = true;
            this.RdoLess.Text = "Less";
            this.RdoLess.UseVisualStyleBackColor = true;
            // 
            // RdoGreater
            // 
            this.RdoGreater.AutoSize = true;
            this.RdoGreater.Location = new System.Drawing.Point(37, 164);
            this.RdoGreater.Margin = new System.Windows.Forms.Padding(4);
            this.RdoGreater.Name = "RdoGreater";
            this.RdoGreater.Size = new System.Drawing.Size(78, 21);
            this.RdoGreater.TabIndex = 3;
            this.RdoGreater.TabStop = true;
            this.RdoGreater.Text = "Greater";
            this.RdoGreater.UseVisualStyleBackColor = true;
            // 
            // BtnReset
            // 
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnReset.Location = new System.Drawing.Point(293, 148);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(267, 62);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rdoLess2);
            this.groupBox2.Controls.Add(this.rdoGreater2);
            this.groupBox2.Controls.Add(this.BtnGenerate2);
            this.groupBox2.Controls.Add(this.BtnReset2);
            this.groupBox2.Controls.Add(this.CmbRandom2);
            this.groupBox2.Location = new System.Drawing.Point(687, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 397);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Group 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 9;
            // 
            // rdoLess2
            // 
            this.rdoLess2.AutoSize = true;
            this.rdoLess2.Location = new System.Drawing.Point(39, 223);
            this.rdoLess2.Name = "rdoLess2";
            this.rdoLess2.Size = new System.Drawing.Size(71, 21);
            this.rdoLess2.TabIndex = 8;
            this.rdoLess2.TabStop = true;
            this.rdoLess2.Text = "Less 2";
            this.rdoLess2.UseVisualStyleBackColor = true;
            // 
            // rdoGreater2
            // 
            this.rdoGreater2.AutoSize = true;
            this.rdoGreater2.Location = new System.Drawing.Point(39, 164);
            this.rdoGreater2.Name = "rdoGreater2";
            this.rdoGreater2.Size = new System.Drawing.Size(90, 21);
            this.rdoGreater2.TabIndex = 7;
            this.rdoGreater2.TabStop = true;
            this.rdoGreater2.Text = "Greater 2";
            this.rdoGreater2.UseVisualStyleBackColor = true;
            // 
            // BtnGenerate2
            // 
            this.BtnGenerate2.Location = new System.Drawing.Point(306, 28);
            this.BtnGenerate2.Name = "BtnGenerate2";
            this.BtnGenerate2.Size = new System.Drawing.Size(267, 62);
            this.BtnGenerate2.TabIndex = 5;
            this.BtnGenerate2.Text = "Generate 2";
            this.BtnGenerate2.UseVisualStyleBackColor = true;
            this.BtnGenerate2.Click += new System.EventHandler(this.BtnGenerate2_Click);
            // 
            // BtnReset2
            // 
            this.BtnReset2.Location = new System.Drawing.Point(306, 143);
            this.BtnReset2.Name = "BtnReset2";
            this.BtnReset2.Size = new System.Drawing.Size(267, 62);
            this.BtnReset2.TabIndex = 6;
            this.BtnReset2.Text = "Reset 2";
            this.BtnReset2.UseVisualStyleBackColor = true;
            this.BtnReset2.Click += new System.EventHandler(this.BtnReset2_Click);
            // 
            // CmbRandom2
            // 
            this.CmbRandom2.FormattingEnabled = true;
            this.CmbRandom2.Location = new System.Drawing.Point(6, 48);
            this.CmbRandom2.Name = "CmbRandom2";
            this.CmbRandom2.Size = new System.Drawing.Size(245, 24);
            this.CmbRandom2.TabIndex = 4;
            this.CmbRandom2.SelectedIndexChanged += new System.EventHandler(this.CmbRandom2_SelectedIndexChanged);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(1162, 492);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(150, 50);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1324, 554);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRandomCombo";
            this.Text = "FrmRandomCombo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.ComboBox CmbRandom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.RadioButton RdoLess;
        private System.Windows.Forms.RadioButton RdoGreater;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CmbRandom2;
        private System.Windows.Forms.Button BtnGenerate2;
        private System.Windows.Forms.Button BtnReset2;
        private System.Windows.Forms.RadioButton rdoLess2;
        private System.Windows.Forms.RadioButton rdoGreater2;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label1;
    }
}