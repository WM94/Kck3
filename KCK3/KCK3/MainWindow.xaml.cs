using KCK3.UserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace KCK3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow instance { set; get; }
        public Grid previous { set; get; }

        public WrapPanel pr { set; get; }



        public MainWindow()
        {
            InitializeComponent();
            repozytorium.repozytorium.init();
            listFakturaSprzedazy.ItemsSource = repozytorium.repozytorium.listFakturaSprzedazy;
            Wydarzenia.ItemsSource = repozytorium.repozytorium.listWydarzenia;
            ListEmail.ItemsSource = repozytorium.repozytorium.listEmail;
            Pracownicy.ItemsSource = repozytorium.repozytorium.listPracownikow;
            listFakturaZakupu.ItemsSource = repozytorium.repozytorium.listFakturaZakupu;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            instance = this;
            previous = Jezyk;
            Grid.SetZIndex(previous, Grid.GetZIndex(previous) * 10);

            pr = BJezyk;
        }

        public void clear()
        {
            listFakturaSprzedazy.ItemsSource = null;
            Wydarzenia.ItemsSource = null;
            ListEmail.ItemsSource = null;
            Pracownicy.ItemsSource = null;
            listFakturaZakupu.ItemsSource = null;
        }
        public void refresh()
        {
            listFakturaSprzedazy.ItemsSource = repozytorium.repozytorium.listFakturaSprzedazy;
            Wydarzenia.ItemsSource = repozytorium.repozytorium.listWydarzenia;
            ListEmail.ItemsSource = repozytorium.repozytorium.listEmail;
            Pracownicy.ItemsSource = repozytorium.repozytorium.listPracownikow;
            listFakturaZakupu.ItemsSource = repozytorium.repozytorium.listFakturaZakupu;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Data.Content = DateTime.Now.ToString();
        }

        public void addNotatka()
        {
            NotatkaContainer.Children.Add(new Notatka());

        }

        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {
              BJezyk.Background = new SolidColorBrush(Colors.DarkGray);
              pr.Background = new SolidColorBrush(Colors.Transparent);
            pr=BJezyk;


            //var t = Grid.GetZIndex(Jezyk) * 10;
            //var s = Grid.GetZIndex(previous) % 9;

            //Grid.SetZIndex(previous, Grid.GetZIndex(previous) % 9);
            //Grid.SetZIndex(Jezyk, Grid.GetZIndex(Jezyk) * 10);
            //previous = Jezyk;
            //Refresh(Jezyk);
        }

        private void TreeViewItem_Selected_1(object sender, RoutedEventArgs e)
        {

            BWyglad.Background = new SolidColorBrush(Colors.DarkGray);
            pr.Background = new SolidColorBrush(Colors.Transparent);
            pr=BWyglad;
            //var t = Grid.GetZIndex(Wyglad) * 10;
            //var s = Grid.GetZIndex(previous) % 9;

            //Grid.SetZIndex(previous, Grid.GetZIndex(previous) % 9);
            //Grid.SetZIndex(Wyglad, Grid.GetZIndex(Wyglad) * 10);
            //previous = Wyglad;
            //      Refresh(Jezyk);
        }

        private void TreeViewItem_Selected_2(object sender, RoutedEventArgs e)
        {
                 BKonto.Background = new SolidColorBrush(Colors.DarkGray);
                 pr.Background = new SolidColorBrush(Colors.Transparent);
            pr=BKonto;
            //Grid.SetZIndex(previous, Grid.GetZIndex(previous) % 9);
            //Grid.SetZIndex(MojeKonto, Grid.GetZIndex(MojeKonto) * 10);
            //previous = MojeKonto;
        }

        private void TreeViewItem_Selected_3(object sender, RoutedEventArgs e)
        {
                 BWyglad.Background = new SolidColorBrush(Colors.DarkGray);
                 pr.Background = new SolidColorBrush(Colors.Transparent);
            pr=BWyglad;

            //Grid.SetZIndex(previous, Grid.GetZIndex(previous) % 9);
            //Grid.SetZIndex(KontoEmail, Grid.GetZIndex(KontoEmail) * 10);
            //previous = KontoEmail;
        }

        private void TreeViewItem_Selected_4(object sender, RoutedEventArgs e)
        {
               BPowiadomienia.Background = new SolidColorBrush(Colors.DarkGray);
               pr.Background = new SolidColorBrush(Colors.Transparent);
            pr=BPowiadomienia;

            //var t = Grid.GetZIndex(Powiadomienia) * 10;
            //var s=  Grid.GetZIndex(previous) % 9;

            //Grid.SetZIndex(previous, Grid.GetZIndex(previous) % 9);
            //Grid.SetZIndex(Powiadomienia, Grid.GetZIndex(Powiadomienia) * 10);
            //previous = Powiadomienia;
           
            
        }

        private void Refresh(Grid g)
        {
            Grid temp = g;
            UstawieniaContainer.Children.Remove(g);
            UstawieniaContainer.Children.Add(temp);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zapisano!");
        }

        private void AddButton_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
  
    }
}
