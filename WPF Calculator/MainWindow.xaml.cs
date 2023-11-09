using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            AllClearBtn.Click += AllClear_Click;
            EqualBtn.Click += EqualBtn_Click;


        }

        double lastNumber;

        double result;

        SelectedOperator selectedOperator;

        internal enum SelectedOperator
        {
            Addition,
            Subtraction,
            Multiplication,
            Division
        }

        private void NumberBtn_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            DisplayLabel.Content += button.Content.ToString();
        }

        private void AllClear_Click(object sender, RoutedEventArgs e)
        {
            DisplayLabel.Content = string.Empty;
        }

        private void DecimalBtn_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            DisplayLabel.Content += button.Content.ToString();
        }

        private void ChangeSignBtn_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            DisplayLabel.Content = Double.Parse(DisplayLabel.Content.ToString()) * -1;
        }

        private void PercentageBtn_Click(Object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            DisplayLabel.Content = Double.Parse(DisplayLabel.Content.ToString()) / 100;

        }

        private void Operation_Click(Object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string textButton = DisplayLabel.Content.ToString();

            switch (textButton)
            {
                case "+":
                    selectedOperator = SelectedOperator.Addition;
                    break;

                case "-":
                    selectedOperator = SelectedOperator.Subtraction;
                    break;

                case "*":
                    selectedOperator = SelectedOperator.Multiplication;
                    break;

                case "/":
                    selectedOperator = SelectedOperator.Division;
                    break;
            }

        }

        private void EqualBtn_Click(Object sender, RoutedEventArgs e)
        {
            result = 0;
            lastNumber = 0;


            switch (selectedOperator)
            {
                case SelectedOperator.Addition:
                    result = MathService.add(operand1, operand2);
                    break;
                case SelectedOperator.Subtraction:
                    result = MathService.subtract(operand1, operand2);
                    break;
                case SelectedOperator.Multiplication:
                    result = MathService.multiply(operand1, operand2);
                    break;
                case SelectedOperator.Division:
                    result = MathService.divide(operand1, operand2);
                    break;
            }



        }



    }

}
