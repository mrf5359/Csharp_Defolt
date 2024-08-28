using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void move_to_LIstBox_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Remove(item);
                listBox1.Items.Add(item);
            }
        }

        private void clear_listBox_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
