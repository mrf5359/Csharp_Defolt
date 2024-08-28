using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace lab6
{
    public partial class frmChild : Form
    {
        public frmChild(lab6.frmContainer parent, string caption)
        {
            InitializeComponent();
            // Присваивание контейнеру родителя данной формы
            this.MdiParent = parent;
            //Задание заголовка
            this.Text = caption;
            rtfText.Font = new Font("Arial", 24);
            timer1.Start();
        }

        private void MenuItemBold_Click(object sender, EventArgs e)
        {
            Font newFont = new Font(rtfText.SelectionFont,	//1
            (rtfText.SelectionFont.Bold ?				//2
            rtfText.SelectionFont.Style & ~FontStyle.Bold :	//3
            rtfText.SelectionFont.Style | FontStyle.Bold));  //4
            rtfText.SelectionFont = newFont;				//5

        }

        private void MenuItemItalic_Click(object sender, EventArgs e)
        {
            Font newFont = new Font(rtfText.SelectionFont,	//1
            (rtfText.SelectionFont.Italic ?				//2
            rtfText.SelectionFont.Style & ~FontStyle.Italic :	//3
            rtfText.SelectionFont.Style | FontStyle.Italic));  //4
            rtfText.SelectionFont = newFont;				//5
        }

        private void MenuItemUnderline_Click(object sender, EventArgs e)
        {
            Font newFont = new Font(rtfText.SelectionFont,	//1
            (rtfText.SelectionFont.Underline ?				//2
            rtfText.SelectionFont.Style & ~FontStyle.Underline :	//3
            rtfText.SelectionFont.Style | FontStyle.Underline));  //4
            rtfText.SelectionFont = newFont;				//5
        }

        private void MenuItemNew_Click(object sender, EventArgs e)
        {
            this.rtfText.Clear();
        }

        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            this.rtfText.LoadFile("test.rtf");
        }

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            rtfText.SaveFile("test.rtf");
        }

        private void MenuItemCancel_Click(object sender, EventArgs e)
        {
            this.rtfText.Undo();
        }

        private void MenuItemRepeat_Click(object sender, EventArgs e)
        {
            this.rtfText.Redo();
        }

        private void MenuItemCopy_Click(object sender, EventArgs e)
        {
            this.rtfText.Copy();
        }

        private void MenuItemCut_Click(object sender, EventArgs e)
        {
            this.rtfText.Cut();
        }

        private void MenuItemPaste_Click(object sender, EventArgs e)
        {
            this.rtfText.Paste();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Checker();
        }
        private void Checker()
        {
            this.MenuItemPaste.Enabled = !IsClipboardEmpty();
            this.MenuItemCopy.Enabled = rtfText.SelectedText.Length > 0 ? true : false;
            this.MenuItemCut.Enabled = rtfText.SelectedText.Length > 0 ? true : false;
            this.MenuItemCancel.Enabled = rtfText.Text.Length > 0 ? true : false;
        }
        public static bool IsClipboardEmpty()
        {
            var dataFormats = typeof(DataFormats).GetFields(BindingFlags.Public | BindingFlags.Static)
                               .Select(f => f.Name);
            var containsSomething = dataFormats.Any(x => Clipboard.ContainsData(x));

            return (!containsSomething);
        }
    }
}