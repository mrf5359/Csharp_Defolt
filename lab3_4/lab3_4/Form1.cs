using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int red_color = vScrollBar_red.Value = 255;
            int green_color = vScrollBar_green.Value = 255;
            int blue_color = vScrollBar_blue.Value = 255;
            red_num.Text = vScrollBar_red.Value.ToString();
            green_num.Text = vScrollBar_green.Value.ToString();
            blue_num.Text = vScrollBar_blue.Value.ToString();
            BackColor = Color.FromArgb(red_color, green_color, blue_color);
        }

        private void vScrollBar_red_Scroll(object sender, ScrollEventArgs e)
        {
            red_num.Text = vScrollBar_red.Value.ToString();
            BackColor = Color.FromArgb(vScrollBar_red.Value, vScrollBar_green.Value, vScrollBar_blue.Value);
        }

        private void vScrollBar_green_Scroll(object sender, ScrollEventArgs e)
        {
            green_num.Text = vScrollBar_green.Value.ToString();
            BackColor = Color.FromArgb(vScrollBar_red.Value, vScrollBar_green.Value, vScrollBar_blue.Value);
        }

        private void vScrollBar_blue_Scroll(object sender, ScrollEventArgs e)
        {
            blue_num.Text = vScrollBar_blue.Value.ToString();
            BackColor = Color.FromArgb(vScrollBar_red.Value, vScrollBar_green.Value, vScrollBar_blue.Value);
        }

    }
}
