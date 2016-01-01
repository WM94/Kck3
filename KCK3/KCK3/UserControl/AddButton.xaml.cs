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
    /// Interaction logic for AddButton.xaml
    /// </summary>
    public partial class AddButton 
    {

        public static readonly DependencyProperty action = DependencyProperty.Register
           (
                "Action",
                typeof(string),
                typeof(AddButton),
                new PropertyMetadata(string.Empty)
           );

        public string Action
        {
            get { return (string)GetValue(action); }
            set { SetValue(action, value); }
        }


       
        public AddButton()
        {
            InitializeComponent();
        
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if(Action=="AddMail")
            {
                SendingEmail wind = new SendingEmail();
                wind.ShowDialog();
            }

            if (Action == "AddFaktura")
            {
                AddEditFaktura wind = new AddEditFaktura();
                if( wind.ShowDialog().Value)
                {
                    MainWindow.instance.clear();
                   repozytorium.repozytorium.listFakturaSprzedazy.Add(wind.faktura);
                    MainWindow.instance.refresh( );
                }
                
            }

            if (Action == "AddFakturaZ")
            {
                AddEditFaktura wind = new AddEditFaktura();
                if (wind.ShowDialog().Value)
                {
                    MainWindow.instance.clear();
                    repozytorium.repozytorium.listFakturaZakupu.Add(wind.faktura);
                    MainWindow.instance.refresh();
                }

            }

            if (Action == "AddPracownik")
            {
                AddEditPracownik wind = new AddEditPracownik();
                if (wind.ShowDialog().Value)
                {
                    MainWindow.instance.clear();
                    repozytorium.repozytorium.listPracownikow.Add(wind.pracownik);
                    MainWindow.instance.refresh();
                }
            }

            if (Action == "AddNotatka")
            {
                MainWindow.instance.addNotatka();
            }

            if (Action == "AddWydarzenie")
            {
                AddWydarzenie temp = new AddWydarzenie();
                temp.ShowDialog();
            }


         

  
            
 

        }
    }
}
