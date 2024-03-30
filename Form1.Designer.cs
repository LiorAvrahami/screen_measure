namespace screen_measure
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonPix = new System.Windows.Forms.RadioButton();
            this.radioButtonCM = new System.Windows.Forms.RadioButton();
            this.Btn_Calibrate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_other_rate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Null";
            // 
            // radioButtonPix
            // 
            this.radioButtonPix.AutoSize = true;
            this.radioButtonPix.Location = new System.Drawing.Point(12, 116);
            this.radioButtonPix.Name = "radioButtonPix";
            this.radioButtonPix.Size = new System.Drawing.Size(51, 17);
            this.radioButtonPix.TabIndex = 3;
            this.radioButtonPix.TabStop = true;
            this.radioButtonPix.Text = "pixels";
            this.radioButtonPix.UseVisualStyleBackColor = true;
            this.radioButtonPix.CheckedChanged += new System.EventHandler(this.radioButtonPix_CheckedChanged);
            // 
            // radioButtonCM
            // 
            this.radioButtonCM.AutoSize = true;
            this.radioButtonCM.Enabled = false;
            this.radioButtonCM.Location = new System.Drawing.Point(12, 139);
            this.radioButtonCM.Name = "radioButtonCM";
            this.radioButtonCM.Size = new System.Drawing.Size(39, 17);
            this.radioButtonCM.TabIndex = 5;
            this.radioButtonCM.TabStop = true;
            this.radioButtonCM.Text = "cm";
            this.radioButtonCM.UseVisualStyleBackColor = true;
            this.radioButtonCM.CheckedChanged += new System.EventHandler(this.radioButtonOther_CheckedChanged);
            // 
            // Btn_Calibrate
            // 
            this.Btn_Calibrate.AutoSize = true;
            this.Btn_Calibrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Calibrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Btn_Calibrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Calibrate.Location = new System.Drawing.Point(12, 198);
            this.Btn_Calibrate.Name = "Btn_Calibrate";
            this.Btn_Calibrate.Size = new System.Drawing.Size(146, 27);
            this.Btn_Calibrate.TabIndex = 6;
            this.Btn_Calibrate.Text = "Calibrate [cm]";
            this.Btn_Calibrate.Click += new System.EventHandler(this.Btn_Calibrate_Click);
            this.Btn_Calibrate.MouseEnter += new System.EventHandler(this.Btn_Calibrate_MouseEnter);
            this.Btn_Calibrate.MouseLeave += new System.EventHandler(this.Btn_Calibrate_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Polygon Area";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // radioButtonOther
            // 
            this.radioButtonOther.AutoSize = true;
            this.radioButtonOther.Location = new System.Drawing.Point(12, 162);
            this.radioButtonOther.Name = "radioButtonOther";
            this.radioButtonOther.Size = new System.Drawing.Size(51, 17);
            this.radioButtonOther.TabIndex = 8;
            this.radioButtonOther.TabStop = true;
            this.radioButtonOther.Text = "Other";
            this.radioButtonOther.UseVisualStyleBackColor = true;
            this.radioButtonOther.CheckedChanged += new System.EventHandler(this.radioButtonOther_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            // 
            // button_other_rate
            // 
            this.button_other_rate.AutoSize = true;
            this.button_other_rate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button_other_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.button_other_rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_other_rate.Location = new System.Drawing.Point(175, 162);
            this.button_other_rate.Name = "button_other_rate";
            this.button_other_rate.Size = new System.Drawing.Size(50, 18);
            this.button_other_rate.TabIndex = 11;
            this.button_other_rate.Text = "Submit";
            this.button_other_rate.Visible = false;
            this.button_other_rate.Click += new System.EventHandler(this.button_other_rate_Click);
            this.button_other_rate.MouseEnter += new System.EventHandler(this.button_other_rate_MouseEnter);
            this.button_other_rate.MouseLeave += new System.EventHandler(this.button_other_rate_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(320, 233);
            this.Controls.Add(this.button_other_rate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButtonOther);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_Calibrate);
            this.Controls.Add(this.radioButtonCM);
            this.Controls.Add(this.radioButtonPix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonPix;
        private System.Windows.Forms.RadioButton radioButtonCM;
        private System.Windows.Forms.Label Btn_Calibrate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonOther;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label button_other_rate;
    }
}

