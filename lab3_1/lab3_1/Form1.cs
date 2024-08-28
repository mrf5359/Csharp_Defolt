using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_toList_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(textBox1.Text, 0);
        }

        private void add_toTree_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;// получаем выделенный узел
            if (node == null)// если выделенного узла нет
            {   
                TreeNode newNode = new TreeNode();// добавляем новый элемент
                newNode.Text = textBox1.Text;// в корень основного дерева
                newNode.ImageIndex = 0;
                treeView1.Nodes.Add(newNode);
            }
            else// если имеется выделенный узел
            {   
                TreeNode newNode = new TreeNode();// добавляем новый элемент
                newNode.Text = textBox1.Text;// как вложенный в выделенный узел
                newNode.ImageIndex = 0;
                node.Nodes.Add(newNode);
            }
        }
        private void deleteTree_btn_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                TreeNode node = treeView1.SelectedNode;
                treeView1.Nodes.Remove(node);
            }
        }
        private void deleteList_btn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.RemoveAt(item.Index);
            }
        }
    }
}
