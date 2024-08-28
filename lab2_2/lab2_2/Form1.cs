using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            listBox1.SelectedIndex = 0;
            radioButton3.Checked = true;
            this.Text = (string)comboBox1.SelectedItem;
            numericUpDown1.Value = this.Height;
            numericUpDown2.Value = this.Width;
            change_font("Times New Roman", 14);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                this.Text = (string)comboBox1.SelectedItem;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                this.Text = (string)comboBox1.SelectedItem;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                this.Text = (string)comboBox1.SelectedItem;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                this.Text = (string)comboBox1.SelectedItem;
            }
        }
        private void change_font(string font, int size)
        {
            comboBox1.Font = new Font(font, size);
            listBox1.Font = new Font(font, size);
            radioButton1.Font = new Font(font, size);
            radioButton2.Font = new Font(font, size);
            radioButton3.Font = new Font(font, size);
            radioButton4.Font = new Font(font, size);
            label1.Font = new Font(font, size);
            label2.Font = new Font(font, size);
            groupBox1.Font = new Font(font, size);

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                change_font("Times New Roman", 14);
            }
            else if (listBox1.SelectedIndex == 1)
            {
                change_font("Arial", 14);
            }
            else if (listBox1.SelectedIndex == 2)
            {
                change_font("Ms Sans Serif", 14); 
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.zima;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.vesna;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.leto;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.osen;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.Height = (int)numericUpDown1.Value;
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.Width = (int)numericUpDown2.Value;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            numericUpDown1.Value = this.Height;
            numericUpDown2.Value = this.Width;
        }
    }
}
