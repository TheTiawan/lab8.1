using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CompareLastName_Click(object sender, RoutedEventArgs e)
        {
            Child father = new Child(Name1.Text, SurName1.Text,Patronymic1.Text);
            Child child = new Child(Name2.Text, SurName2.Text, Patronymic2.Text);

            int answer = father.CompareTo(child);
            if (answer == 1) Result.Text = "Фамилии совпадают";
            if (answer == -1) Result.Text = "Фамилии различны";
        }

        private void GetInfo_Click(object sender, RoutedEventArgs e)
        {
            Child father = new Child(Name1.Text,SurName1.Text,Patronymic1.Text);
            Result.Text = father.PrintName();
        }

        private void GetSonInfo_Click(object sender, RoutedEventArgs e)
        {
            Child son = new Child(Name2.Text,SurName2.Text, Patronymic2.Text);
            Result.Text = son.Print();
        }

        private void AboutProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать интерфейс - человек, у которого есть имя, функция печати.\nСоздать класс отец, у которого функция печати выводит имя.\nСоздать класс ребенок, у которого есть отец, отчество, функция печати выводит имя и отчество.\nКлассы должны включать конструкторы.\nСравнение производить по фамилии.\nРазработчик Халимов Виктор");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
