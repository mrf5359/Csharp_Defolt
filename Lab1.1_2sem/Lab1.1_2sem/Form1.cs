using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1._1_2sem
{
    public partial class Form1 : Form
    {
        private List<ExhibitionHall> exhibitionHalls = new List<ExhibitionHall>();
        private string dataFilePath = "SavedFile.dat";
        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = ExhibitionHallsListBox.SelectedIndex;
            if (selectedIndex >= 0)
            {
                ExhibitionHall exhibitionHALL = exhibitionHalls[selectedIndex];
                string artworkName = ArtworkNameTextBox.Text;
                int yearCreated = int.Parse(YearCreatedTextBox.Text);
                double width = double.Parse(WidthTextBox.Text);
                double height = double.Parse(HeightTextBox.Text);
                double depth = double.Parse(DepthTextBox.Text);
                string fundsName = FundsNameTextBox.Text;
                string fundsAddress = FundsAddressTextBox.Text;
                PlacementType placement = (PlacementType)PlacementComboBox.SelectedIndex;
                Funds funds = new Funds(fundsName, fundsAddress);
                Artwork artwork = new Artwork(artworkName, yearCreated, width, height, depth);
                Exhibit exhibit = new Exhibit(artwork, funds, placement);
    

                exhibitionHALL.AddExhibit(exhibit);
                MessageBox.Show("Экспонат добавлен в выставочный зал.");
            }
            else
            {
                MessageBox.Show("Выберите выставочный зал из списка.");
            }
        }

        private void fullInfoButton_Click(object sender, EventArgs e)
        {
            ExhibitionHall exhibitionHALL = (ExhibitionHall)ExhibitionHallsListBox.SelectedItem;
            outputTextBox.Text = exhibitionHALL.GetFullInformation();
        }

        private void summaryInfoButton_Click(object sender, EventArgs e)
        {
            ExhibitionHall exhibitionHALL = (ExhibitionHall)ExhibitionHallsListBox.SelectedItem;
            outputTextBox.Text = exhibitionHALL.GetSummaryInformation();
        }

        private void addHallButton_Click(object sender, EventArgs e)
        {
            if (ExhibitionHallNameTextBox.Text == "")
            {
                MessageBox.Show("Пустое поле добавлять не нада");
                return;
            }
            string hallName = ExhibitionHallNameTextBox.Text;
            ExhibitionHall newHall = new ExhibitionHall(hallName);

            // Добавьте новый зал в коллекцию выставочных залов вашего приложения
            exhibitionHalls.Add(newHall);
            ExhibitionHallsListBox.Items.Add(newHall);

            ExhibitionHallNameTextBox.Text = "";

            MessageBox.Show("Новый выставочный зал добавлен: " + hallName);

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
        }

        private void overloadButton_Click(object sender, EventArgs e)
        {
            Date date = new Date(20, 5, 2023);
            int daysToAdd = 10;
            Date newDate = date + daysToAdd;

            Exhibit exhibit1 = new Exhibit(new Artwork("Artwork 1", 2020, 10, 10, 10), new Funds("Funds 1", "Address 1"), PlacementType.Wall);
            Exhibit exhibit2 = new Exhibit(new Artwork("Artwork 2", 2021, 15, 15, 15), new Funds("Funds 2", "Address 2"), PlacementType.Table);

            Artwork artwork1 = new Artwork("Artwork 1", 2020, 10, 10, 10);
            Artwork artwork2 = new Artwork("Artwork 2", 2021, 15, 15, 15);
            Artwork artwork3 = new Artwork("Artwork 1", 2020, 10, 10, 10);

            bool isExhibit1Cheaper = exhibit1 < exhibit2;
            bool isExhibit2Cheaper = exhibit1 > exhibit2;

            bool areArtworksEqual1 = artwork1 == artwork2;
            bool areArtworksEqual2 = artwork1 == artwork3;
            bool areArtworksNotEqual = artwork1 != artwork2;

            ExhibitionHall exhibitionHall = new ExhibitionHall("Зал 1");
            exhibitionHall.AddExhibit(new Exhibit(new Artwork("Artwork 1", 2020, 10, 10, 10), new Funds("Funds 1", "Address 1"), PlacementType.Wall));
            exhibitionHall.Exhibits[0].Artwork.Name = "Новое название";

            overloadLabel.Text = $"Новая дата: {newDate.Day}.{newDate.Month}.{newDate.Year}\n";
            overloadLabel.Text += $"Exhibit1 дешевле Exhibit2: {isExhibit1Cheaper}\nExhibit2 дешевле Exhibit1: {isExhibit2Cheaper}\n";
            overloadLabel.Text += $"Artwork1 равен Artwork2: {areArtworksEqual1}\nArtwork1 равен Artwork3: {areArtworksEqual2}\nArtwork1 не равен Artwork2: {areArtworksNotEqual}\n";
            overloadLabel.Text += $"Название экспоната в выставочном зале: {exhibitionHall.Exhibits[0].Artwork.Name}";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fileStream = new FileStream(dataFilePath, FileMode.Create))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(fileStream, exhibitionHalls);
                    MessageBox.Show("Data saved successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(dataFilePath))
                {
                    using (FileStream fileStream = new FileStream(dataFilePath, FileMode.Open))
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        exhibitionHalls = (List<ExhibitionHall>)binaryFormatter.Deserialize(fileStream);
                    }
                    MessageBox.Show("Данные успешно загружены из файла.");
                    UpadeExhibitionHallsList();
                }
                else
                {
                    MessageBox.Show("Файл данных не найден.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных из файла. " + ex.Message);
            }
        }

        private void UpadeExhibitionHallsList()
        {
            ExhibitionHallsListBox.Items.Clear();
            foreach (ExhibitionHall exhibitionHall in exhibitionHalls)
            {
                ExhibitionHallsListBox.Items.Add(exhibitionHall);
            }
        }
    }

    [Serializable]
    enum PlacementType
    {
        Wall,
        Table,
        Floor
    }

    // Класс "Фонды"
    [Serializable]
    class Funds
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Funds(string name, string address)
        {
            MessageBox.Show("Створено об'єкт класу Funds: " + name);
            Name = name;
            Address = address;
        }
    }

    // Класс "Произведение искусства"
    [Serializable]
    class Artwork
    {
        public string Name { get; set; }
        public int YearCreated { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }

        public Artwork(string name, int yearCreated, double width, double height, double depth)
        {
            MessageBox.Show("Створено об'єкт класу Artwork: " + name);
            Name = name;
            YearCreated = yearCreated;
            Width = width;
            Height = height;
            Depth = depth;
        }
        public static bool operator ==(Artwork artwork1, Artwork artwork2)
        {
            // Проверяем совпадение свойств двух произведений искусства
            return artwork1.Name == artwork2.Name &&
                   artwork1.YearCreated == artwork2.YearCreated &&
                   artwork1.Width == artwork2.Width &&
                   artwork1.Height == artwork2.Height &&
                   artwork1.Depth == artwork2.Depth;
        }

        public static bool operator !=(Artwork artwork1, Artwork artwork2)
        {
            // Проверяем отличие свойств двух произведений искусства
            return !(artwork1 == artwork2);
        }

    }
    // Класс "Экспонат"
    [Serializable]
    class Exhibit:Artwork
    {
        public Artwork Artwork { get; set; }
        public Funds Funds { get; set; }
        public PlacementType Placement { get; set; }

        public Exhibit(Artwork artwork, Funds funds, PlacementType placement)
        :base (artwork.Name,artwork.YearCreated,artwork.Width,artwork.Height,artwork.Depth)
        {
            MessageBox.Show("Створено об'єкт класу Exhibit: " + artwork.Name);
            Artwork = artwork;
            Funds = funds;
            Placement = placement;
        }
        public static bool operator <(Exhibit exhibit1, Exhibit exhibit2)
        {
            // Сравниваем стоимость двух экспонатов
            return GetExhibitCost(exhibit1) < GetExhibitCost(exhibit2);
        }

        public static bool operator >(Exhibit exhibit1, Exhibit exhibit2)
        {
            // Сравниваем стоимость двух экспонатов
            return GetExhibitCost(exhibit1) > GetExhibitCost(exhibit2);
        }

        private static double GetExhibitCost(Exhibit exhibit)
        {
            // Вычисляем стоимость экспоната на основе его размеров
            return exhibit.Artwork.Width * exhibit.Artwork.Height * exhibit.Artwork.Depth;
        }
    }

    // Класс "Выставочный зал"
    [Serializable]
    class ExhibitionHall
    {
        public string Name { get; set; }
        public List<Exhibit> Exhibits { get; set; }

        public ExhibitionHall(string name)
        {
            Name = name;
            Exhibits = new List<Exhibit>();
        }

        public void AddExhibit(Exhibit exhibit)
        {
            Exhibits.Add(exhibit);
        }

        public string GetFullInformation()
        {
            string info = "Название зала: " + Name + "\r\n";
            info += "Экспонаты:\r\n";
            int i = 1;
            foreach (Exhibit exhibit in Exhibits)
            {
                Artwork artwork = exhibit.Artwork;
                Funds funds = exhibit.Funds;
                PlacementType placement = exhibit.Placement;

                info += "Экспонат " + i + ":\r\n";
                info += "  Название: " + artwork.Name + "\r\n";
                info += "  Год создания: " + artwork.YearCreated + "\r\n";
                info += "  Размещение: " + placement.ToString() + "\r\n";
                info += "  Размеры: " + artwork.Width + " x " + artwork.Height + " x " + artwork.Depth + "\r\n";
                info += "  Фонд: " + funds.Name + ", Адрес: " + funds.Address + "\r\n";
                i++;
            }
            return info;
        }

        public string GetSummaryInformation()
        {
            string info = "Название зала: " + Name + "\r\n";
            int i = 1;
            foreach (Exhibit exhibit in Exhibits)
            { 
                Artwork artwork = exhibit.Artwork;
                info += "Экспонат " + i + ":\r\n";
                info += "  Название: " + artwork.Name + "\r\n";
                info += "  Год создания: " + artwork.YearCreated + "\r\n";
                i++;
            }
            return info;
        }
        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable]
    class Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public static Date operator +(Date date, int daysToAdd)
        {
            // Добавляем указанное количество дней к дате
            // Возвращаем новый объект класса Date с обновленной датой
            int totalDays = date.Day + daysToAdd;
            int maxDaysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            while (totalDays > maxDaysInMonth)
            {
                totalDays -= maxDaysInMonth;
                date.Month++;
                if (date.Month > 12)
                {
                    date.Month = 1;
                    date.Year++;
                }
                maxDaysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            }
            date.Day = totalDays;
            return date;
        }
    }
}

