using KCK3._class;
using KCK3.EditWindows;
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

namespace KCK3.UserControl
{
    /// <summary>
    /// Interaction logic for EditButton.xaml
    /// </summary>
    public partial class EditButton 
    {
        public static readonly DependencyProperty action = DependencyProperty.Register
   (
        "Action",
        typeof(string),
        typeof(EditButton),
        new PropertyMetadata(string.Empty)
   );

        public string Action
        {
            get { return (string)GetValue(action); }
            set { SetValue(action, value); }
        }

        public EditButton()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Action == "AddMail")
            {
                SendingEmail wind = new SendingEmail();
                wind.ShowDialog();
            }

            if (Action == "AddFaktura")
            {
                var temp = MainWindow.instance.listFakturaSprzedazy.SelectedItem as Faktura;
                if (temp == null) { MessageBox.Show("Brak zaznaczonej pozycji"); return; }
                AddEditFaktura wind = new AddEditFaktura(temp);
                if (wind.ShowDialog().Value)
                {
                    //////temp = wind.faktura;
                    ////MainWindow.instance.clear();
                    //repozytorium.repozytorium.listFakturaSprzedazy.Add(wind.faktura);
                    ///// MainWindow.instance.refresh();
                }

            }

            if (Action == "AddFakturaZ")
            {
                var temp = MainWindow.instance.listFakturaZakupu.SelectedItem as Faktura;
                if (temp == null) { MessageBox.Show("Brak zaznaczonej pozycji"); return; }
                AddEditFaktura wind = new AddEditFaktura(temp);
                if (wind.ShowDialog().Value)
                {
                   // MainWindow.instance.clear();
                   /// repozytorium.repozytorium.listFakturaZakupu.Add(wind.faktura);
                   //// MainWindow.instance.refresh();
                }

            }

            if (Action == "AddPracownik")
            {
                var temp = MainWindow.instance.Pracownicy.SelectedItem as Pracownik;
                if (temp == null) { MessageBox.Show("Brak zaznaczonej pozycji"); return; }
                AddEditPracownik wind = new AddEditPracownik(temp);
                if (wind.ShowDialog().Value)
                {
                   /// MainWindow.instance.clear();
                   /// repozytorium.repozytorium.listPracownikow.Add(wind.pracownik);
                    ///MainWindow.instance.refresh();
                }
            }

            if (Action == "AddNotatka")
            {
               // MainWindow.instance.addNotatka();
            }

            if (Action == "AddWydarzenie")
            {
                //var temp = MainWindow.instance.listFakturaZakupu.SelectedItem as Faktura;
                //if (temp == null) { MessageBox.Show("Brak zaznaczonej pozycji"); return; }
                //AddWydarzenie wind = new AddWydarzenie(temp);
                //if (wind.ShowDialog().Value)
                //{
                //    MainWindow.instance.clear();
                //    repozytorium.repozytorium.listFakturaZakupu.Add(wind.faktura);
                //    MainWindow.instance.refresh();
                //}
            }
 
        }
    }
}
