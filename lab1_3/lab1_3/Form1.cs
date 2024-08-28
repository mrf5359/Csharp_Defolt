using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosed += Form1_FormClosed;
        }

        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            new System.Threading.Thread(() => { Application.Run(new Form2()); }).Start();
        }
    }
    public partial class Form2 : Form
    {
        public Form2()
        {
        }
    }
}
