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
    /// Interaction logic for AddEditPracownik.xaml
    /// </summary>
    public partial class AddEditPracownik : Window
    {
        public Pracownik pracownik { set; get; }
        public AddEditPracownik(Pracownik prac =null)
        {
            pracownik = prac == null ? new Pracownik() : prac;
            InitializeComponent();
            this.DataContext = pracownik;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult rez = MessageBox.Show("Czy chcesz anulać?", " Potwierdzenie", MessageBoxButton.YesNo);
            if (rez == MessageBoxResult.Yes) this.Close();
        }
    }
}
