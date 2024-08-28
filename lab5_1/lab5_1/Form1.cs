using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_1
{
    public partial class Form1 : Form
    {
        public enum Tools
        {
            PEN = 1, TEXT, LINE, ELLIPSE, NULL = 0
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
            foreach (ToolStripMenuItem item1 in menuToolStripItem.DropDownItems)
            {
                if (item1 == item) { item1.Checked = true; }
                else { item1.Checked = false; }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Tools curentTool;
            switch (e.ClickedItem.Name)
            {
                case "toolStripButtonPen":
                    curentTool = Tools.PEN;
                    SetToolStripMenuItemPushedState(menuItemPen);
                    statusStrip1.Items[0].Text = "Выбран карандаш"; break;
                case "toolStripButtonText":
                    curentTool = Tools.TEXT;
                    SetToolStripMenuItemPushedState(menuItemText);
                    statusStrip1.Items[0].Text = "Создание надписей"; break;
                case "toolStripButtonLine":
                    curentTool = Tools.LINE;
                    SetToolStripMenuItemPushedState(menuItemLine);
                    statusStrip1.Items[0].Text = "Рисование линий"; break;
                case "toolStripButtonEllipse":
                    curentTool = Tools.ELLIPSE;
                    SetToolStripMenuItemPushedState(menuItemEllipse);
                    statusStrip1.Items[0].Text = "Рисование эллипса"; break;
            }
            SetToolStripButtonsPushedState(e.ClickedItem);
        }

        private void menuToolStripItem_Click(object sender, EventArgs e)
        {
            Tools curentTool;
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string text = item.Text;
            switch (text)
            {
                case "Карандаш":
                    curentTool = Tools.PEN;
                    SetToolStripButtonsPushedState(toolStripButtonPen);
                    statusStrip1.Items[0].Text = "Выбран карандаш";
                    break;
                case "Текст":
                    curentTool = Tools.TEXT;
                    SetToolStripButtonsPushedState(toolStripButtonText);
                    statusStrip1.Items[0].Text = "Создание надписей";
                    break;
                case "Линия":
                    curentTool = Tools.LINE;
                    SetToolStripButtonsPushedState(toolStripButtonLine);
                    statusStrip1.Items[0].Text = "Рисование линий";
                    break;
                case "Эллипс":
                    curentTool = Tools.ELLIPSE;
                    SetToolStripButtonsPushedState(toolStripButtonEllipse);
                    statusStrip1.Items[0].Text = "Рисование эллипса";
                    break;
            }
            SetToolStripMenuItemPushedState(item);
        }
    }
}
