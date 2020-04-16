namespace project_1
{
    partial class FrmCars
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
            this.btnStartMyCar = new System.Windows.Forms.Button();
            this.btnStartHisCar = new System.Windows.Forms.Button();
            this.btnAccelerateMyCar = new System.Windows.Forms.Button();
            this.btnAccelerateHisCar = new System.Windows.Forms.Button();
            this.btnStopMyCar = new System.Windows.Forms.Button();
            this.btnStopHisCar = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartMyCar
            // 
            this.btnStartMyCar.Location = new System.Drawing.Point(19, 67);
            this.btnStartMyCar.Name = "btnStartMyCar";
            this.btnStartMyCar.Size = new System.Drawing.Size(150, 50);
            this.btnStartMyCar.TabIndex = 0;
            this.btnStartMyCar.Text = "Start My Car";
            this.btnStartMyCar.UseVisualStyleBackColor = true;
            this.btnStartMyCar.Click += new System.EventHandler(this.btnStartMyCar_Click);
            // 
            // btnStartHisCar
            // 
            this.btnStartHisCar.Location = new System.Drawing.Point(19, 202);
            this.btnStartHisCar.Name = "btnStartHisCar";
            this.btnStartHisCar.Size = new System.Drawing.Size(150, 50);
            this.btnStartHisCar.TabIndex = 1;
            this.btnStartHisCar.Text = "Start His Car";
            this.btnStartHisCar.UseVisualStyleBackColor = true;
            this.btnStartHisCar.Click += new System.EventHandler(this.btnStartHisCar_Click);
            // 
            // btnAccelerateMyCar
            // 
            this.btnAccelerateMyCar.Location = new System.Drawing.Point(211, 67);
            this.btnAccelerateMyCar.Name = "btnAccelerateMyCar";
            this.btnAccelerateMyCar.Size = new System.Drawing.Size(150, 50);
            this.btnAccelerateMyCar.TabIndex = 2;
            this.btnAccelerateMyCar.Text = "Accelerate My Car";
            this.btnAccelerateMyCar.UseVisualStyleBackColor = true;
            this.btnAccelerateMyCar.Click += new System.EventHandler(this.btnAccelerateMyCar_Click);
            // 
            // btnAccelerateHisCar
            // 
            this.btnAccelerateHisCar.Location = new System.Drawing.Point(211, 202);
            this.btnAccelerateHisCar.Name = "btnAccelerateHisCar";
            this.btnAccelerateHisCar.Size = new System.Drawing.Size(150, 50);
            this.btnAccelerateHisCar.TabIndex = 3;
            this.btnAccelerateHisCar.Text = "Accelerate His Car";
            this.btnAccelerateHisCar.UseVisualStyleBackColor = true;
            this.btnAccelerateHisCar.Click += new System.EventHandler(this.btnAccelerateHisCar_Click);
            // 
            // btnStopMyCar
            // 
            this.btnStopMyCar.Location = new System.Drawing.Point(403, 67);
            this.btnStopMyCar.Name = "btnStopMyCar";
            this.btnStopMyCar.Size = new System.Drawing.Size(150, 50);
            this.btnStopMyCar.TabIndex = 4;
            this.btnStopMyCar.Text = "Stop My Car";
            this.btnStopMyCar.UseVisualStyleBackColor = true;
            this.btnStopMyCar.Click += new System.EventHandler(this.btnStopMyCar_Click);
            // 
            // btnStopHisCar
            // 
            this.btnStopHisCar.Location = new System.Drawing.Point(403, 202);
            this.btnStopHisCar.Name = "btnStopHisCar";
            this.btnStopHisCar.Size = new System.Drawing.Size(150, 50);
            this.btnStopHisCar.TabIndex = 5;
            this.btnStopHisCar.Text = "Stop His Car";
            this.btnStopHisCar.UseVisualStyleBackColor = true;
            this.btnStopHisCar.Click += new System.EventHandler(this.btnStopHisCar_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(597, 398);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 40);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStopHisCar);
            this.groupBox1.Controls.Add(this.btnStopMyCar);
            this.groupBox1.Controls.Add(this.btnAccelerateHisCar);
            this.groupBox1.Controls.Add(this.btnAccelerateMyCar);
            this.groupBox1.Controls.Add(this.btnStartHisCar);
            this.groupBox1.Controls.Add(this.btnStartMyCar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 322);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cars";
            // 
            // FrmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Name = "FrmCars";
            this.Text = "FrmCars";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartMyCar;
        private System.Windows.Forms.Button btnStartHisCar;
        private System.Windows.Forms.Button btnAccelerateMyCar;
        private System.Windows.Forms.Button btnAccelerateHisCar;
        private System.Windows.Forms.Button btnStopMyCar;
        private System.Windows.Forms.Button btnStopHisCar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}