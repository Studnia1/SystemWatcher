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

namespace WPFaplikacja
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string sciezka;
        ServiceReference1.WatcherServiceClient client;
        public MainWindow()
        {
            InitializeComponent();
            client = new ServiceReference1.WatcherServiceClient();


        }

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    client.WypiszDaneDyskow();
        //    lvUsers.ItemsSource = client.WypiszDaneDyskow();

        //}
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            client.Run();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            client.Stop();
            lvUsers.ItemsSource = client.PobierzListeZmian();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            lvUsers2.ItemsSource = client.WypiszDaneDyskow();
        }

        private void lvUsers2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sciezka = textbox1.Text;
            client.GetPath(sciezka);
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
