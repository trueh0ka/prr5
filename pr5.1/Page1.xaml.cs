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
namespace pr5._1
{
    public partial class Page1 : Page
    {
        DateTime dateTime = new DateTime();
        public Page1()
        {
            InitializeComponent();
            days();
            dateTime = DateTime.Today;
            DatePicker.DisplayDate= dateTime;
            DatePicker.Text= dateTime.ToString();
            month();
        }

        private void days()
        {
            Day1.DayName.Text = "1";
            Day2.DayName.Text = "2";
            Day3.DayName.Text = "3";
            Day4.DayName.Text = "4";
            Day5.DayName.Text = "5";
            Day6.DayName.Text = "6";
            Day7.DayName.Text = "7";
            Day8.DayName.Text = "8";
            Day9.DayName.Text = "9";
            Day10.DayName.Text = "10";
            Day11.DayName.Text = "11";
            Day12.DayName.Text = "12";
            Day13.DayName.Text = "13";
            Day14.DayName.Text = "14";
            Day15.DayName.Text = "15";
            Day16.DayName.Text = "16";
            Day17.DayName.Text = "17";
            Day18.DayName.Text = "18";
            Day19.DayName.Text = "19";
            Day20.DayName.Text = "20";
            Day21.DayName.Text = "21";
            Day22.DayName.Text = "22";
            Day23.DayName.Text = "23";
            Day24.DayName.Text = "24";
            Day25.DayName.Text = "25";
            Day26.DayName.Text = "26";
            Day27.DayName.Text = "27";
            Day28.DayName.Text = "28";
            Day29.DayName.Text = "29";
            Day30.DayName.Text = "30";
            Day31.DayName.Text = "31";
        }

        private void month()
        {
            int a;
            a = dateTime.Month;
            
            switch (a)
            {
                case 1:
                    Day29.Visibility = Visibility.Visible;
                    Day30.Visibility = Visibility.Visible;
                    Day31.Visibility = Visibility.Visible;
                    break;
                case 2:
                    Day29.Visibility = Visibility.Hidden;
                    Day30.Visibility = Visibility.Hidden;
                    Day31.Visibility = Visibility.Hidden;
                    break;
                case 3:
                    Day29.Visibility = Visibility.Visible;
                    Day30.Visibility = Visibility.Visible;
                    Day31.Visibility = Visibility.Visible;
                    break;
                case 4:
                    Day29.Visibility = Visibility.Visible;
                    Day30.Visibility = Visibility.Visible;
                    Day31.Visibility = Visibility.Hidden;
                    break;
                case 5:
                    Day29.Visibility = Visibility.Visible;
                    Day30.Visibility = Visibility.Visible;
                    Day31.Visibility = Visibility.Visible;
                    break;
                case 6:
                    Day29.Visibility = Visibility.Visible;
                    Day30.Visibility = Visibility.Visible;
                    Day31.Visibility = Visibility.Hidden;
                    break;
                case 7:
                    Day29.Visibility = Visibility.Visible;
                    Day30.Visibility = Visibility.Visible;
                    Day31.Visibility = Visibility.Visible;
                    break;
                case 8:
                    Day29.Visibility = Visibility.Visible;
                    Day30.Visibility = Visibility.Visible;
                    Day31.Visibility = Visibility.Visible;
                    break;
                case 9:
                    Day29.Visibility = Visibility.Visible;
                    Day30.Visibility = Visibility.Visible;
                    Day31.Visibility = Visibility.Hidden;
                    break;
                case 10:
                    Day29.Visibility = Visibility.Visible;
                    Day30.Visibility = Visibility.Visible;
                    Day31.Visibility = Visibility.Visible;
                    break;
                case 11:
                    Day29.Visibility = Visibility.Visible;
                    Day30.Visibility = Visibility.Visible;
                    Day31.Visibility = Visibility.Hidden;
                    break;
                case 12:
                    Day29.Visibility = Visibility.Visible;
                    Day30.Visibility = Visibility.Visible;
                    Day31.Visibility = Visibility.Hidden;
                    break;
            }
        }

        private void nazadDay_Click(object sender, RoutedEventArgs e)
        {
            dateTime = dateTime.AddMonths(-1);
            DatePicker.DisplayDate = dateTime;
            DatePicker.Text = dateTime.ToString();
            month();
        }

        private void vperedDay_Click(object sender, RoutedEventArgs e)
        {
            dateTime = dateTime.AddMonths(1);
            DatePicker.DisplayDate = dateTime;
            DatePicker.Text = dateTime.ToString();
            month();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                dateTime = Convert.ToDateTime(DatePicker.Text);
                month();
            }
        }

        public void Navigator()
        {
            NavigationService.Navigate(new Uri("Page2.xaml", UriKind.Relative));
        }
    }
}