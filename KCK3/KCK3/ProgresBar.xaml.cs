using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Threading;

namespace KCK3
{
    /// <summary>
    /// Interaction logic for ProgresBar.xaml
    /// </summary>
    public partial class ProgresBar : Window
    {
        private event ProgressChangedEventHandler UpdateProgressChanged;
        private readonly Task _updateTask;
        public ProgresBar()
        {
            InitializeComponent();

            go();
          
           /// this.Close();
            ///
            ///this.Close();
          ////  _updateTask = new Task(ref UpdateProgressChanged);

        }
        private void OnUpdateProgressChanged(int progressPercentage)
        {
            if (UpdateProgressChanged != null)
            {
                UpdateProgressChanged(this, new ProgressChangedEventArgs(progressPercentage, null));
            }
        }

        public void go()
        {
            int progress = 0;
            DispatcherTimer timer = new DispatcherTimer() { Interval = TimeSpan.FromSeconds(0.005) };
            timer.Tick += (sSub, eSub) =>
            {
              ///////  progress++;

                this.progresBar.Value++;
                // Raise progress changed event which in turn will change
                // the progress of the task which in turn will cause
                // the binding to update which in turn causes the value
                // of the ProgressBar to change.
                ///OnUpdateProgressChanged(progress);
                if (this.progresBar.Value == 100)
                {
                  
                    timer.Stop();
                    this.Close();
                }
            };
            timer.Start();

            //for (int i = 0; i < 100; i++)
            //{

            //    this.Dispatcher.BeginInvoke((Action)delegate()
            //    {
            //        Thread.Sleep(5);
            //        this.progresBar.Value++;

            //        if (progresBar.Value == 100)
            //        {
            //            Thread.Sleep(5000);
            //            MessageBox.Show("close");
            //        }



            //    });

            //}

          //this.Dispatcher.BeginInvoke((Action)delegate()
          // {
          //      Thread.Sleep(500);

                
          //              Thread.Sleep(1000);
          //               this.Close();
               


          //});
        }
    }
}
