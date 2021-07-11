using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screen_measure
{
    public partial class CalbForm : Form
    {
        public CalbForm()
        {
            InitializeComponent();
            CalbForm_SizeChanged(null, null);
            textBox1.Text = (Form1.PixToCmRate * (pictureBox2.Location.X - pictureBox1.Location.X - pictureBox1.Width)).ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void CalbForm_SizeChanged(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(this.Width - 35,pictureBox1.Location.Y);
            pictureBox3.Width = pictureBox2.Location.X - pictureBox1.Location.X - pictureBox1.Width;
            pictureBox5.Location = new Point(pictureBox2.Location.X - pictureBox5.Width, pictureBox5.Location.Y);
            label1.Location = new Point((this.Width) / 2 - label1.Width / 2, label1.Location.Y);
            textBox1.Location = new Point((this.Width + Btn_Calibrate.Location.X + Btn_Calibrate.Width) / 2 - textBox1.Width / 2, textBox1.Location.Y);
        }

        private void Btn_Calibrate_Click(object sender, EventArgs e)
        {
            try
            {
                double X = double.Parse(textBox1.Text);
                Form1.PixToCmRate = X / (pictureBox2.Location.X - pictureBox1.Location.X - pictureBox1.Width);
                //Dump To Memory
                System.IO.File.WriteAllText("ScreenMeasureDat.dat", Form1.PixToCmRate.ToString());
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("enter a real number (maby number was to large or to precise)");
            }
        }

        private void label_button_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).BackColor = Color.FromArgb(140, 255, 140);
        }

        private void label_button_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).BackColor = Color.FromArgb(90, 230, 90);
        }
    }
}
