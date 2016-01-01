using KCK3._class;
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
using System.Windows.Shapes;

namespace KCK3.EditWindows
{
    /// <summary>
    /// Interaction logic for AddEditFaktura.xaml
    /// </summary>
    public partial class AddEditFaktura : Window
    {
        public Faktura faktura { set; get; }
        public AddEditFaktura(Faktura fakt=null)
        {
            faktura = fakt == null ? new Faktura() : fakt;
         
            InitializeComponent();
            _Grid.DataContext = faktura;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           /// MessageBox.Show("Czy chcesz wysłać maila?", " Potwierdzenie", MessageBoxButton.YesNo);
            this.DialogResult = true;
            this.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            MessageBoxResult rez = MessageBox.Show("Czy chcesz anulać?", " Potwierdzenie", MessageBoxButton.YesNo);
            if (rez == MessageBoxResult.Yes) this.Close();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
