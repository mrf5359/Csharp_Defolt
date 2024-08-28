using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_2
{
    public partial class Form1 : Form
    {
        public enum Tools
        {
            RED = 1, BLUE, GREEN, YELLOW, NULL = 0
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void SetToolStripButtonsPushedState(ToolStripItem button)
        {
            foreach (ToolStripButton btnItem in toolStrip1.Items)
            {
                if (btnItem == button) { btnItem.Checked = true; }
                else { btnItem.Checked = false; }
            }
        }

        private void SetToolStripMenuItemPushedState(ToolStripMenuItem item)
        {
            foreach (ToolStripMenuItem item1 in menuBackgroundColor.DropDownItems)
            {
                if (item1 == item) { item1.Checked = true; }
                else { item1.Checked = false; }
            }
        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            Tools curentTool;
            switch (e.ClickedItem.Name)
            {
                case "toolStripButtonRed":
                    curentTool = Tools.RED;
                    SetToolStripMenuItemPushedState(menuItemRed);
                    this.BackColor = Color.Red;
                    statusStrip1.Items[0].Text = "Цвет фона: Красный"; break;
                case "toolStripButtonBlue":
                    curentTool = Tools.BLUE;
                    SetToolStripMenuItemPushedState(menuItemBlue);
                    this.BackColor = Color.Blue;
                    statusStrip1.Items[0].Text = "Цвет фона: Синий"; break;
                case "toolStripButtonGreen":
                    curentTool = Tools.GREEN;
                    SetToolStripMenuItemPushedState(menuItemGreen);
                    this.BackColor = Color.FromArgb(127, 255, 0);
                    statusStrip1.Items[0].Text = "Цвет фона: Зелёный"; break;
                case "toolStripButtonYellow":
                    curentTool = Tools.YELLOW;
                    SetToolStripMenuItemPushedState(menuItemYellow);
                    this.BackColor = Color.Yellow;
                    statusStrip1.Items[0].Text = "Цвет фона: Жёлтый"; break;
            }
            SetToolStripButtonsPushedState(e.ClickedItem);
        }

        private void menuBackgroundColor_Click(object sender, EventArgs e)
        {
            Tools curentTool;
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string text = item.Text;
            switch (text)
            {
                case "Красный":
                    curentTool = Tools.RED;
                    this.BackColor = Color.Red;
                    SetToolStripButtonsPushedState(toolStripButtonRed);
                    statusStrip1.Items[0].Text = "Цвет фона: Красный"; break;
                case "Синий":
                    curentTool = Tools.BLUE;
                    this.BackColor = Color.Blue;
                    SetToolStripButtonsPushedState(toolStripButtonBlue);
                    statusStrip1.Items[0].Text = "Цвет фона: Синий"; break;
                case "Зеленый":
                    curentTool = Tools.GREEN;
                    this.BackColor = Color.FromArgb(127, 255, 0);
                    SetToolStripButtonsPushedState(toolStripButtonGreen);
                    statusStrip1.Items[0].Text = "Цвет фона: Зелёный"; break;
                case "Жёлтый":
                    curentTool = Tools.YELLOW;
                    SetToolStripButtonsPushedState(toolStripButtonYellow);
                    this.BackColor = Color.Yellow;
                    statusStrip1.Items[0].Text = "Цвет фона: Жёлтый"; break;
            }
            SetToolStripMenuItemPushedState(item);
        }
    }
}
