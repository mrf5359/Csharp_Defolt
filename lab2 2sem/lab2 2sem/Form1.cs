using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_2sem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        class ProizvedenieIskusstva
        {
            private string nazva;

            public ProizvedenieIskusstva()
            {
                MessageBox.Show("Створено об'єкт базового класу ProizvedenieIskusstva");
            }

            public ProizvedenieIskusstva(string nazva)
            {
                this.nazva = nazva;
                MessageBox.Show($"Створено об'єкт базового класу ProizvedenieIskusstva з назвою: {nazva}");
            }

            public void VydavatyInformatsiyu()
            {
                MessageBox.Show("Це произведение искусства.");
            }
        }

        class Eksponat : ProizvedenieIskusstva
        {
            private int rokStvorennia;

            public Eksponat() : base()
            {
                MessageBox.Show("Створено об'єкт похідного класу Eksponat");
            }

            public Eksponat(string nazva, int rokStvorennia) : base(nazva)
            {
                this.rokStvorennia = rokStvorennia;
                MessageBox.Show($"Створено об'єкт похідного класу Eksponat з назвою: {nazva}, роком створення: {rokStvorennia}");
            }

            public new void VydavatyInformatsiyu()
            {
                base.VydavatyInformatsiyu();
                MessageBox.Show($"Цей експонат був створений у {rokStvorennia} році.");
            }
        }

        class Program
        {
            public void Main(string[] args)
            {
                Application.Run(new MainForm());
            }
        }

        class MainForm : Form
        {
            public MainForm()
            {
                ProizvedenieIskusstva proizvedenie1 = new ProizvedenieIskusstva();
                ProizvedenieIskusstva proizvedenie2 = new ProizvedenieIskusstva("Живопис");

                Eksponat eksponat1 = new Eksponat();
                Eksponat eksponat2 = new Eksponat("Скульптура", 2020);

                proizvedenie1.VydavatyInformatsiyu();
                eksponat1.VydavatyInformatsiyu();
            }
        }

    }
}
