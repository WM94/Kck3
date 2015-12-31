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
    /// Interaction logic for Notatka.xaml
    /// </summary>
    public partial class Notatka 
    {

        public static readonly DependencyProperty text = DependencyProperty.Register
        (
             "TextNotatka",
             typeof(string),
             typeof(Notatka),
             new PropertyMetadata(string.Empty)
        );

        public string Text
        {
            get { return (string)GetValue(text); }
            set { SetValue(text, value); }
        }



        public Notatka()
        {
            InitializeComponent();
     

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Czy chcesz usunać notatkę", "Potwierdzenie", MessageBoxButton.YesNo);
        }
    }
}
