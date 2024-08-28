using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Font = new Font("Arial", 24);
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog {Filter = "Text Documents (*.rtf)|*.rtf|All files|*.*"};
            dlg.Title = "Выберите файл для редактирования";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(dlg.FileName);
            }
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog { Filter = "Text Documents (*.rtf)|*.rtf|All files|*.*" };
            dlg.Title = "Сохранить файл";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(dlg.FileName);
            }
        }

        private void font_bold_btn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Style == FontStyle.Bold)
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, richTextBox1.Font.Style & ~FontStyle.Bold);
            else
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
        }

        private void font_underline_btn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Style == FontStyle.Underline)
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, richTextBox1.Font.Style & ~FontStyle.Underline);
            else
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
        }

        private void font_inclined_btn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Style == FontStyle.Italic)
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, richTextBox1.Font.Style & ~FontStyle.Italic);
            else
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
        }

        private void center_btn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionAlignment == HorizontalAlignment.Center)
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            else if (richTextBox1.SelectionAlignment == HorizontalAlignment.Left)
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void font_size_tbox_TextChanged(object sender, EventArgs e)
        {
            if (font_size_tbox.Text == "")
                return;
            richTextBox1.Font = new Font("Arial", Convert.ToInt32(font_size_tbox.Text));
        }

        private void font_size_tbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {  
                return;// цифра
            }
            if (Char.IsControl(e.KeyChar))
            {  
                if (e.KeyChar == (char)Keys.Back)// нажата клавиша <Backspace>
                    return;
            }
            e.Handled = true;// Остальные символы запрещены
        }
    }
}
