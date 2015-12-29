using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KCK3
{
    /// <summary>
    /// Interaction logic for ProgresBar.xaml
    /// </summary>
    public partial class ProgresBar : Window
    {
        public ProgresBar()
        {
            InitializeComponent();

            go();
          
           /// this.Close();
            ///
            ///this.Close();


        }

        public void go()
        {
            for (int i = 0; i < 100; i++)
            {

                this.Dispatcher.BeginInvoke((Action)delegate()
                {
                    Thread.Sleep(5);
                    this.progresBar.Value ++;

                    if(progresBar.Value==100)

                        
                    {
                    }
                  
                  

                });
             
            }

          //this.Dispatcher.BeginInvoke((Action)delegate()
          // {
          //      Thread.Sleep(500);

                
          //              Thread.Sleep(1000);
          //               this.Close();
               


          //});
        }
    }
}
