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
    public partial class Form1 : Form
    {
        Point Pt1 = new Point(-1000,-1000);
        Point Pt2 = new Point(-1000,-1000);
        bool inputToPt1 = true;
        public static double PixToCmRate = -1;
        public static double PixToOtherRate = 1;

        public double last_distance_printed_on_label = 0;

        public Form1()
        {
            InitializeComponent();
            try
            {
                Form1.PixToCmRate = double.Parse(System.IO.File.ReadAllText("ScreenMeasureDat.dat"));
            }
            catch (Exception){}
            
            if (PixToCmRate > 0)
                radioButtonCM.Enabled = true;
        }

        private void Btn_Calibrate_MouseEnter(object sender, EventArgs e)
        {
            Btn_Calibrate.BackColor = Color.FromArgb(255, 180, 180);
        }

        private void Btn_Calibrate_MouseLeave(object sender, EventArgs e)
        {
            Btn_Calibrate.BackColor = Color.FromArgb(255, 128, 128);
        }

        private void Btn_Calibrate_Click(object sender, EventArgs e)
        {
            new CalbForm().ShowDialog();
            if (PixToCmRate > 0)
                radioButtonCM.Enabled = true;
            print();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (inputToPt1)
                {
                    Pt1 = Cursor.Position;
                    label1.BackColor = Color.FromArgb(120, 255, 120);
                    label2.BackColor = Color.FromArgb(180, 255, 180);
                    label3.BackColor = Color.FromArgb(180, 255, 180);
                    inputToPt1 = false;
                }
                else
                {
                    Pt2 = Cursor.Position;
                    label1.BackColor = Color.FromArgb(120, 255, 120);
                    label2.BackColor = Color.FromArgb(120, 255, 120);
                    label3.BackColor = Color.FromArgb(120, 255, 120);
                    inputToPt1 = true;
                }
                print();
            }

        }
        void print()
        {
            double Molt = 1;
            if (PixToCmRate > 0 && radioButtonCM.Checked)
                Molt = PixToCmRate;
            if (radioButtonOther.Checked)
                Molt = PixToOtherRate;
            if (Pt1.X != -1000)
                label1.Text = "Point1: X = " + Math.Round(Pt1.X * Molt, 2).ToString() + " , Y = " + Math.Round(Pt1.Y * Molt, 2).ToString();
            if (Pt2.X != -1000)
            {
                label2.Text = "Point2: X = " + Math.Round(Pt2.X * Molt,2).ToString() + " , Y = " + Math.Round(Pt2.Y * Molt,2).ToString();
                double Distance = Math.Round(Molt * get_distance(Pt1,Pt2), 2);
                last_distance_printed_on_label = Distance;
                label3.Text = "Distance = " + Distance.ToString();
                if (textBox1.Visible)
                    textBox1.Text = Distance.ToString();
            }
        }
        double get_distance(Point Pt1, Point Pt2)
        {
            return Math.Sqrt((Pt2.X - Pt1.X) * (Pt2.X - Pt1.X) + (Pt2.Y - Pt1.Y) * (Pt2.Y - Pt1.Y));
        }

        private void radioButtonPix_CheckedChanged(object sender, EventArgs e)
        {
            print();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonOther_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOther.Checked)
            {
                textBox1.Visible = true;
                button_other_rate.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                button_other_rate.Visible = false;
            }
            textBox1.Text = last_distance_printed_on_label.ToString();
        }

        private void button_other_rate_Click(object sender, EventArgs e)
        {
            if (get_distance(Pt1, Pt2) == 0)
                return;
            double recwested_length = 0;
            bool parse_succsess = double.TryParse(textBox1.Text, out recwested_length);
            if (recwested_length == 0 || !parse_succsess)
            {
                MessageBox.Show("enter a real number (maby number was to large or to precise)");
                return;
            }
            PixToOtherRate = recwested_length / get_distance(Pt1,Pt2);
            print();
            label1.Focus();
        }

        private void button_other_rate_MouseEnter(object sender, EventArgs e)
        {
            button_other_rate.BackColor = Color.FromArgb(230, 230, 230);
        }

        private void button_other_rate_MouseLeave(object sender, EventArgs e)
        {
            button_other_rate.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
