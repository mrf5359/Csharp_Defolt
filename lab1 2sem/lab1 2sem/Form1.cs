using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace lab1_2sem
{
    public partial class Form1 : Form
    {
        private Student student;

        public Form1()
        {
            InitializeComponent();
        }

        private Person person;
        private Exam exam1;
        private void Form1_Load(object sender, EventArgs e)
        {
            

            // Создаем объекты для студента и экзамена
            person = new Person("Данил", "Рак", new DateTime(2004, 7, 25));
            student = new Student(person, EducationLevel.Bachelor);
            exam1 = new Exam("СП", 85, new DateTime(2023, 5, 20));

            // Добавляем экзамен студенту
            student.AddExam(exam1);

            // Заполняем элементы управления значениями из объекта студента
            fullNameLabel.Text = person.GetFullName();
            birthDateLabel.Text = person.GetBirthDate().ToString("dd/MM/yyyy");
            educationLevelLabel.Text = student.GetEducationLevel().ToString();

            // Отображаем информацию о сданных экзаменах
            examsListBox.Items.Clear();
            foreach (Exam exam in student.GetExams())
            {
                examsListBox.Items.Add($"{exam.GetExamName()} - {exam.GetGrade()} - {exam.GetDateTaken()}");
            }

            // Отображаем сокращенную информацию о студенте
            shortInfoLabel.Text = $"Фамилия: {person.GetLastName()}\nAverage Grade: {student.CalculateAverageGrade()}";
        }

        private void PersonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(person.DisplayInfo());
        }

        private void ExamInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(exam1.DisplayInfo());
        }

        private void FullInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(student.GetFullInfo());
        }

        private void SummaryInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(student.GetSummaryInfo());
        }

        private void AddExam_Click(object sender, EventArgs e)
        {
            string examName = ExamName.Text;
            if (int.TryParse(ExamMark.Text, out int examMark))
            {
                // Преобразование прошло успешно, examMark содержит целочисленное значение
                DateTime examDate = ExamDate.Value;

                // Создаем экземпляр класса Exam с полученными данными
                exam1 = new Exam(examName, examMark, examDate);

                // Добавляем строку с информацией об экзамене в ListBox
                examsListBox.Items.Add($"{exam1.GetExamName()} - {exam1.GetGrade()}");
            }
            else
            {
                // Невозможно преобразовать строку в целое число, обработка ошибки
                MessageBox.Show("Некорректный формат оценки экзамена. Введите целое число.");
            }

        }
    }

    // Перечисление для типа "Уровень образования"
    public enum EducationLevel
    {
        Bachelor,
        Specialist,
        Master
    }

    public class Person
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        // Конструктор класса
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
        }

        // Методы доступа к данным персоны
        public string GetFullName()
        {
            return $"{firstName} {lastName}";
        }

        public DateTime GetBirthDate()
        {
            return dateOfBirth;
        }

        public string GetLastName()
        {
            return lastName;
        }

        // Метод для вывода информации о персоне
        public string DisplayInfo()
        {
            string info = $"Full Name: {firstName} {lastName}";
            info += $"\nDate of Birth: {dateOfBirth.ToString("dd/MM/yyyy")}";
            return info ;
        }
    }

    public class Exam
    {
        private string examName;
        private int grade;
        private DateTime dateTaken;

        // Методы доступа к данным экзамена
        public int Grade
        {
            get { return grade; }
        }

        public string GetExamName()
        {
            return examName;
        }

        public int GetGrade()
        {
            return grade;
        }

        public DateTime GetDateTaken()
        {
            return dateTaken;
        }
        // Конструктор класса
        public Exam(string examName, int grade, DateTime dateTaken)
        {
            this.examName = examName;
            this.grade = grade;
            this.dateTaken = dateTaken;
        }

        // Метод для вывода информации об экзамене
        public string DisplayInfo()
        {
            string info = $"Exam Name: {examName}";
            info += $"\nGrade: {grade}";
            info += $"\nDate Taken: {dateTaken.ToString("dd/MM/yyyy")}" ;
            return info;
        }
    }

    class Student
    {
        private Person person;
        private EducationLevel educationLevel;
        private List<Exam> exams;

        // Конструктор класса
        public Student(Person person, EducationLevel educationLevel)
        {
            this.person = person;
            this.educationLevel = educationLevel;
            exams = new List<Exam>();
        }

        // Метод для добавления сданного экзамена к списку
        public void AddExam(Exam exam)
        {
            exams.Add(exam);
        }

        // Метод для вывода полной информации о студенте
        public string GetFullInfo()
        {
            string fullInfo = "";
            fullInfo += "Full Name: " + person.GetFullName() + "\n";
            fullInfo += "Date of Birth: " + person.GetBirthDate().ToString("dd/MM/yyyy") + "\n";
            fullInfo += "Education Level: " + educationLevel + "\n";
            fullInfo += "Exams Taken:\n";
            foreach (Exam exam in exams)
            {
                fullInfo += exam.GetExamName() + " - " + exam.GetGrade() + "\n";
            }

            return fullInfo;
        }

        // Метод для вывода сокращенной информации о студенте
        public string GetSummaryInfo()
        {
            string summaryInfo = "";
            summaryInfo += "Student: " + person.FirstName + " " + person.LastName + "\n";
            summaryInfo += "Average Grade: " + CalculateAverageGrade();

            return summaryInfo;
        }

        // Метод для вычисления средней оценки студента
        public double CalculateAverageGrade()
        {
            double totalGrade = 0;
            foreach (Exam exam in exams)
            {
                totalGrade += exam.Grade;
            }
            return totalGrade / exams.Count;
        }

        public EducationLevel GetEducationLevel()
        {
            return educationLevel;
        }

        public Exam[] GetExams()
        {
            return exams.ToArray();
        }
    }
}
