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

namespace Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        long number1 = 0;
        long number2 = 0;
        long number3 = 0;
        string operation = "";


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                fönstret.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                fönstret.Text = number2.ToString();
            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                fönstret.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                fönstret.Text = number2.ToString();
            }

        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                fönstret.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                fönstret.Text = number2.ToString();
            }

        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                fönstret.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                fönstret.Text = number2.ToString();
            }

        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                fönstret.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                fönstret.Text = number2.ToString();
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                fönstret.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                fönstret.Text = number2.ToString();
            }

        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                fönstret.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                fönstret.Text = number2.ToString();
            }

        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                fönstret.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                fönstret.Text = number2.ToString();
            }

        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                fönstret.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                fönstret.Text = number2.ToString();
            }

        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                fönstret.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                fönstret.Text = number2.ToString();
            }

        }

        private void Btn_plus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            fönstret.Text = "0";
            number1 = number1 + number2;
            number2 = 0;
        }

        private void Btn_minus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            fönstret.Text = "0";
            number1 = number1 - number2;
            number2 = -0;
        }

        private void Btn_multi_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            fönstret.Text = "0";
            number2 = 1;
            number3 = number1 * number2;
            number2 = 0;
        }

        private void Btn_dive_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            fönstret.Text = "0";
            number1 = number1 / number2;
            number2 = 0;
        }

        private void Btn_svar_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    fönstret.Text = (number1 + number2).ToString();
                    number1 = number1 + number2;
                    number2 = 0;
                    break;
                case "-":
                    fönstret.Text = (number1 - number2).ToString();
                    number1 = number1 - number2;
                    number2 = 0;
                    break;
                case "*":
                    fönstret.Text = (number1 * number2).ToString();
                    number1 = number1 * number2;
                    number2 = 0;
                    break;
                case "/":
                    fönstret.Text = (number1 / number2).ToString();
                    number1 = number1 / number2;
                    number2 = 0;
                    break;
            }
        }

        private void Btn_ce_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
            fönstret.Text = "0";
        }

        private void Btn_c_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            fönstret.Text = "0";
        }

        private void Btn_tabort_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10);
                fönstret.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                fönstret.Text = number2.ToString();
            }

        }

        private void Btn_talchanger_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *= -1;
                fönstret.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                fönstret.Text = number2.ToString();
            }

        }

        private void Btn_artur_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Artur was here");
        }

        private void Fönstret_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
