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
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();


            vibor first = new vibor();
            first.ViborName.Text = "Пицца";
            Uri pizza = new Uri("C:\\Users\\vipal\\Downloads\\pizza.png", UriKind.Absolute);
            first.image2.Source = new BitmapImage(pizza);
            vibor second = new vibor();
            second.ViborName.Text = "Суп";
            Uri sup = new Uri("C:\\Users\\vipal\\Downloads\\sup.png", UriKind.Absolute);
            second.image2.Source = new BitmapImage(sup);
            vibor third = new vibor();
            third.ViborName.Text = "Картошка";
            Uri free = new Uri("C:\\Users\\vipal\\Downloads\\free.png", UriKind.Absolute);
            third.image2.Source = new BitmapImage(free);
            vibor fourth = new vibor();
            fourth.ViborName.Text = "Бургер";
            Uri burger = new Uri("C:\\Users\\vipal\\Downloads\\burger.png", UriKind.Absolute);
            fourth.image2.Source = new BitmapImage(burger);
            vibor fifth = new vibor();
            fifth.ViborName.Text = "Пончик";
            Uri ponchik = new Uri("C:\\Users\\vipal\\Downloads\\ponchik.jpg", UriKind.Absolute);
            fifth.image2.Source = new BitmapImage(ponchik);
            List<vibor> list = new List<vibor>() { first, second, third, fourth, fifth};
            ListBox.ItemsSource= list;
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
        }

        private void nazadSohr_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
        }
    }
}