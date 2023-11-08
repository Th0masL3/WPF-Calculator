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

namespace WPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DecimalBtn.Click += DecimalBtn_Click;
            ChangeSignBtn.Click += ChangeSignBtn_Click;
            PercentageBtn.Click += PercentageBtn_Click;



        }


        double lastNumber;
        
        double result;

      

        private void NumberBtn_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            DisplayLabel.Content += button.Content.ToString();
        }

        private void DecimalBtn_Click( object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            DisplayLabel.Content += button.Content.ToString();  
        }

        private void ChangeSignBtn_Click (object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            DisplayLabel.Content = Double.Parse(DisplayLabel.Content.ToString()) * -1;
        }

        private void PercentageBtn_Click(Object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            DisplayLabel.Content = Double.Parse(DisplayLabel.Content.ToString()) / 100;

        }






    }
}
