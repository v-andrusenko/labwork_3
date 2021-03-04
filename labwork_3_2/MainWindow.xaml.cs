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

namespace labwork_3_2
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

        public event EventHandler Add;
        public event EventHandler Subtract;
        public event EventHandler Multiply;
        public event EventHandler Divide;
        public event EventHandler Clear;

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            try
            {
                Add(sender, e);
            }
            catch
            {
                MessageBox.Show("Проверьте корректность введённых данных");
            }
        }

        private void Button_Subtract(object sender, RoutedEventArgs e)
        {
            try
            {
                Subtract(sender, e);
            }
            catch
            {
                MessageBox.Show("Проверьте корректность введённых данных");
            }

        }

        private void Button_Multiply(object sender, RoutedEventArgs e)
        {
            try
            {
                Multiply(sender, e);
            }
            catch
            {
                MessageBox.Show("Проверьте корректность введённых данных");
            } 
        }

        private void Button_Divide(object sender, RoutedEventArgs e)
        {
            try
            {
                Divide(sender, e);
            }
            catch
            {
                MessageBox.Show("Проверьте корректность введённых данных");
            }
            
        }

        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            Clear(sender, e);
        }
    }
}
