using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            work_checkBox.Checked = true;
            ok_btn.Enabled = false;
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            result_text.Text = "Имя = Ваше имя" +
                               "\r\nАдрес = Ваш адрес" +
                               "\r\nПрограммист = отметьте 'Программист' если вы являетесь программистом" +
                               "\r\nПол = Выберите ваш пол" +
                               "\r\nВозраст = Ваш возраст";
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            string sex = "";
            string workplace = "";
            if (women_radio.Checked)
                sex = "Женский";
            if (men_radio.Checked)
                sex = "Мужской";
            if (work_checkBox.Checked)
                workplace = "Программист";
            else
                workplace = "";
            result_text.Text = $"Имя: {name_textBox.Text}" +
                               $"\r\nАдрес: {adress_textBox.Text}" +
                               $"\r\nПрофесия: {workplace}" +
                               $"\r\nПол: {sex}" +
                               $"\r\nВозраст: {age_textBox.Text}";
        }

        private void age_textBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void enable_btn()
        {
            if ((women_radio.Checked || men_radio.Checked) && name_textBox.Text != "" && adress_textBox.Text != "" && age_textBox.Text != "")
                ok_btn.Enabled = true;
            else
                ok_btn.Enabled = false;
        }

        private void name_textBox_TextChanged(object sender, EventArgs e)
        {
            enable_btn();
        }

        private void adress_textBox_TextChanged(object sender, EventArgs e)
        {
            enable_btn();
        }

        private void women_radio_CheckedChanged(object sender, EventArgs e)
        {
            enable_btn();
        }

        private void men_radio_CheckedChanged(object sender, EventArgs e)
        {
            enable_btn();
        }

        private void age_textBox_TextChanged(object sender, EventArgs e)
        {
            enable_btn();
        }
    }
}
