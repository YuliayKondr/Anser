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
//using System.Timers;
using System.Threading;
namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer dispatcherTimer;
        private volatile bool isTick;
        public MainWindow()
        {
            InitializeComponent();
            isTick = false;
            if (!myBall.Resources.Contains("anser")) myBall.Resources.Add("anser", "Задай вопрос");
            else
            {
                myBall.Resources["anser"] = "Задай вопрос";
            }
            
        }
      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {   
            
            if (!myBall.Resources.Contains("anser"))
                myBall.Resources.Add("anser", AnserBall.Anser());
            else            
            {
                myBall.Resources["anser"]=AnserBall.Anser();                       
            }
            if (dispatcherTimer != null)
            {
                dispatcherTimer.Stop();
                isTick = false;
            }
            if (!isTick)
            {                               
                dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
                dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
                dispatcherTimer.Interval = new TimeSpan(0, 0, 10);
                dispatcherTimer.Start();
                isTick = true;
            }
        }



        private void MyBall_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {            
            if (sender is System.Windows.Threading.DispatcherTimer)
            {
                System.Windows.Threading.DispatcherTimer timer = sender as System.Windows.Threading.DispatcherTimer;
                timer.Stop();
                isTick = false;
            }
            if (!myBall.Resources.Contains("anser")) myBall.Resources.Add("anser", "Задай вопрос");
            else
            {
                try
                {
                    myBall.Resources["anser"] = "Задай вопрос";
                }catch(Exception ex)
                {
                    string str = ex.ToString();
                }
            }
            
        }
    }
}
