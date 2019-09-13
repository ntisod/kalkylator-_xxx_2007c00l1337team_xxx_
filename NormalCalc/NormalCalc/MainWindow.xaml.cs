using System;
using System.Collections.Generic;
using System.Data;
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

namespace NormalCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        // knappar
        private void Btn_ce_Click(object sender, RoutedEventArgs e)
        {
            fönstret.Text = "0";
        }

        private void Btn_c_Click(object sender, RoutedEventArgs e)
        {
            fönstret.Text = "0";
        }
        // knapp som ta bort symbol i början
        private void Btn_tabort_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                fönstret.Text = fönstret.Text.Substring(0, Convert.ToInt32(fönstret.Text.Length) - 1);
            } catch
            {
                fönstret.Text = "0";
            }
        }

        // funtions knappar
        private void Btn_plus_Click(object sender, RoutedEventArgs e)
        {

            if (fönstret.Text == "0")
                fönstret.Text = "+";
            else fönstret.Text += "+";
        }

        private void Btn_minus_Click(object sender, RoutedEventArgs e)
        {

            if (fönstret.Text == "0")
                fönstret.Text = "-";
            else fönstret.Text += "-";
        }

        private void Btn_multi_Click(object sender, RoutedEventArgs e)
        {
            if (fönstret.Text == "0")
                fönstret.Text = "*";
            else fönstret.Text += "*";
        }

        private void Btn_dive_Click(object sender, RoutedEventArgs e)
        {

            if (fönstret.Text == "0")
                fönstret.Text = "/";
            else fönstret.Text += "/";
        }

        // räknar ut svaret
        private void Btn_svar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                var v = dt.Compute(fönstret.Text, "");
                fönstret.Text = v.ToString();
            }
            catch
            {
                fönstret.Text = "error";
            }
        }
        // 1,2,3,4,5,6,7,8,9,0
        private void Btn_talchanger_Click(object sender, RoutedEventArgs e)
        {
            if (fönstret.Text == "0")
                fönstret.Text = ",";
            else fönstret.Text += ",";
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (fönstret.Text == "0")
                fönstret.Text = "1";
            else fönstret.Text += "1";
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (fönstret.Text == "0")
                fönstret.Text = "2";
            else fönstret.Text += "2";
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (fönstret.Text == "0")
                fönstret.Text = "3";
            else fönstret.Text += "3";
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (fönstret.Text == "0")
                fönstret.Text = "4";
            else fönstret.Text += "4";
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (fönstret.Text == "0")
                fönstret.Text = "5";
            else fönstret.Text += "5";
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (fönstret.Text == "0")
                fönstret.Text = "6";
            else fönstret.Text += "6";
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (fönstret.Text == "0")
                fönstret.Text = "7";
            else fönstret.Text += "7";
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (fönstret.Text == "0")
                fönstret.Text = "8";
            else fönstret.Text += "8";
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (fönstret.Text == "0")
                fönstret.Text = "9";
            else fönstret.Text += "9";
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (fönstret.Text == "0")
                fönstret.Text = "0";
            else fönstret.Text += "0";
        }

        private void Fönstret_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        // Min knapp
        private void Btn_artur_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Artur and Hassan was here! V 2.0");
        }
    }
}
