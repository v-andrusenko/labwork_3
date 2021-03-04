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
using System.Windows.Threading;


namespace labwork_3_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
  
        }

        public event EventHandler Start;
        public event EventHandler Stop;
        public event EventHandler Reset;

        private void Button_Click_Start(object sender, RoutedEventArgs e)
        {
            Start(sender, e);
        }

        private void Button_Click_Stop(object sender, RoutedEventArgs e)
        {
            Stop(sender, e);
        }

        private void Button_Click_Reset(object sender, RoutedEventArgs e)
        {
            Reset(sender, e);
        }
    }
}
