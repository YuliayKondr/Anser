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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        public MainWindow()
        {
            InitializeComponent();
            
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
            if (!myBall.Resources.Contains("anser")) myBall.Resources.Add("anser", AnserBall.Anser());
            else
            {
                myBall.Resources["anser"]=AnserBall.Anser();
            }
           
        }

        private void MyBall_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
