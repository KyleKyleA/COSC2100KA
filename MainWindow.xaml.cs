using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

//REGION FUNCTIONS
namespace CalculatorApp
{
    /// <summary>
    /// Methods and logic for MainWindow.xaml
    /// This is a way to separate the UI from the logic
    /// How to build a simple calculator in WPF
    /// First doing the UI Design in XAML
    /// Then doing the logic in C#
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textCalculate_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textClear_Click(object sender, RoutedEventArgs e)
        {
            textCalculate.Clear();
            textCalculate.Focus();


        }

        private void textDelete_Click(object sender, RoutedEventArgs e)
        {

            if (textCalculate.Text.Length > 0)
            {
                textCalculate.Text = textCalculate.Text.Substring(0, textCalculate.Text.Length - 1);
            }
        }


        // Note to self: You need a double parse for every function depending on the arugment according to the parameter
        private void textEqual_Click(object sender, RoutedEventArgs e)
        {

            string expression = textCalculate.Text;

            if (expression.Contains("+"))
            {
                string[] parts = expression.Split('+');
                if (double.TryParse(parts[0], out double num1) && double.TryParse(parts[1], out double num2))
                {
                    double sum = num1 + num2;
                    textCalculate.Text = sum.ToString();
                    return;
                }
                else
                {
                    textCalculate.Text = "Syntax Error";
                }
            }

            else if (expression.Contains("-"))
            {
                string[] parts = expression.Split('-');
                if (double.TryParse(parts[0], out double num1) && double.TryParse(parts[1], out double num2))
                {
                    double minus = num1 - num2;
                    textCalculate.Text = minus.ToString();
                    return;
                }
                else
                {
                    textCalculate.Text = "Syntax Error";
                }

            }

            /// Multiplication and Division 
            else if (expression.Contains("*"))
            {
                string[] parts = expression.Split('*');
                if (double.TryParse(parts[0], out double num1) && double.TryParse(parts[1], out double num2))
                {
                    double mutiply = num1 * num2;
                    textCalculate.Text = mutiply.ToString();
                    return;
                }
                else
                {
                    textCalculate.Text = "Syntax Error";
                }
            }

            else if (expression.Contains("/"))
            {
                string[] parts = expression.Split('/');
                if (double.TryParse(parts[0], out double num1) && double.TryParse(parts[1], out double num2))
                {
                    double division = num1 / num2;
                    textCalculate.Text = division.ToString();
                    return;
                }
                else
                {
                    textCalculate.Text = "Syntax Error";
                }
            }

            else if (expression.Contains("√"))
            {
                string[] parts = expression.Split('√');
                if (double.TryParse(parts[0], out double num1) && double.TryParse(parts[1], out double num2))
                {
                    double squareRoot = Math.Sqrt(num2);
                    textCalculate.Text = squareRoot.ToString();
                    return;
                }
                else
                {
                    textCalculate.Text = "Syntax Error";
                }
            }
            else if (expression.Contains("㏒"))
            {
                string numberPart = expression.Replace("㏒", "");
                if (double.TryParse(numberPart, out double num))
                {
                    double log = Math.Log10(num);
                    textCalculate.Text = log.ToString();
                    return;
                }
                else
                {
                    textCalculate.Text = "Syntax Error";
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
              textCalculate.Text += button.Content.ToString();
            }
        }

        private void text1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
//ENDREGION FUNCTIONS





















