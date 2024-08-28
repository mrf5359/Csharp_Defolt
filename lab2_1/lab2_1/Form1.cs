using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            button2.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i--;
            label1.Text = i.ToString() + " cек.";
            progressBar1.Value += 1000;
            Random rnd = new Random();
            BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                this.Close();
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                progressBar1.Maximum = 1000;
                i = (int)numericUpDown1.Value;
                progressBar1.Maximum *= (int)numericUpDown1.Value;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                progressBar1.Maximum = 1000;
                i = (int)numericUpDown1.Value * 60;
                progressBar1.Maximum *= (int)numericUpDown1.Value * 60;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                progressBar1.Maximum = 1000;
                i = (int)numericUpDown1.Value * 3600;
                progressBar1.Maximum *= (int)numericUpDown1.Value * 3600;
            }
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                progressBar1.Maximum = 1000;
                i = (int)numericUpDown1.Value;
                progressBar1.Maximum *= (int)numericUpDown1.Value;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                progressBar1.Maximum = 1000;
                i = (int)numericUpDown1.Value * 60;
                progressBar1.Maximum *= (int)numericUpDown1.Value * 60;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                progressBar1.Maximum = 1000;
                i = (int)numericUpDown1.Value * 3600;
                progressBar1.Maximum *= (int)numericUpDown1.Value * 3600;
            }
        }
    }
}
