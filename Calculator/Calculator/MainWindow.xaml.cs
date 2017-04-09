// Tien Dinh - CSCI3037-001 - Calculator

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

namespace Calculator
{
    public partial class MainWindow : Window
    {
        int[] numbersArray = new int[20];
        string[] operatorsArray = new string[19];

        string storeVar;
        int numbersCount = 0;
        int operatorsCount = 0;
        bool calculated = false;
        int total;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (calculated == true)
            {
                DisplayCalculation.Text = "";
                calculated = false;
            }

            DisplayCalculation.Text += "1";
            storeVar += "1";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (calculated == true)
            {
                DisplayCalculation.Text = "";
                calculated = false;
            }

            DisplayCalculation.Text += "2";
            storeVar += "2";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (calculated == true)
            {
                DisplayCalculation.Text = "";
                calculated = false;
            }

            DisplayCalculation.Text += "3";
            storeVar += "3";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (calculated == true)
            {
                DisplayCalculation.Text = "";
                calculated = false;
            }

            DisplayCalculation.Text += "4";
            storeVar += "4";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (calculated == true)
            {
                DisplayCalculation.Text = "";
                calculated = false;
            }

            DisplayCalculation.Text += "5";
            storeVar += "5";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (calculated == true)
            {
                DisplayCalculation.Text = "";
                calculated = false;
            }

            DisplayCalculation.Text += "6";
            storeVar += "6";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (calculated == true)
            {
                DisplayCalculation.Text = "";
                calculated = false;
            }

            DisplayCalculation.Text += "7";
            storeVar += "7";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (calculated == true)
            {
                DisplayCalculation.Text = "";
                calculated = false;
            }

            DisplayCalculation.Text += "8";
            storeVar += "8";
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (calculated == true)
            {
                DisplayCalculation.Text = "";
                calculated = false;
            }

            DisplayCalculation.Text += "9";
            storeVar += "9";
        }

        void setNumber(String Number)
        {
            numbersArray[numbersCount] = Convert.ToInt16(Number);
            storeVar = "";
            numbersCount++;
        }
        void setOperator(String Op)
        {
            operatorsArray[operatorsCount] = Op;
            operatorsCount++;
        }

        private void button0_Click_1(object sender, RoutedEventArgs e)
        {
            if (calculated == true)
            {
                DisplayCalculation.Text = "";
                calculated = false;
            }

            DisplayCalculation.Text += "9";
            storeVar += "9";
        }

        private void buttonClear_Click_1(object sender, RoutedEventArgs e)
        {
            DisplayCalculation.Text = "";
            DisplayResult.Text = "";
            for (int i = 0; i < 20; i++)
                numbersArray[i] = 0;
            for (int i = 0; i < 19; i++)
                operatorsArray[i] = "";
            storeVar = "";
            numbersCount = 0;
            operatorsCount = 0;
            total = 0;
        }

        private void Equal_Click_1(object sender, RoutedEventArgs e)
        {
            setNumber(storeVar);
            for (int i = 0; i < operatorsCount; i++)
            {
                if (operatorsArray[i] == "+" && i == 0)
                {
                    total = numbersArray[i] + numbersArray[i + 1];
                }
                else if (operatorsArray[i] == "+")
                {
                    total = total + numbersArray[i + 1];
                }
                else if (operatorsArray[i] == "-" && i == 0)
                {
                    total = numbersArray[i] - numbersArray[i + 1];
                }
                else if (operatorsArray[i] == "-")
                {
                    total = total - numbersArray[i + 1];
                }
                else if (operatorsArray[i] == "*" && i == 0)
                {
                    total = numbersArray[i] * numbersArray[i + 1];
                }
                else if (operatorsArray[i] == "*")
                {
                    total = total * numbersArray[i + 1];
                }
                else if (operatorsArray[i] == "/" && i == 0)
                {
                    total = numbersArray[i] / numbersArray[i + 1];
                }
                else if (operatorsArray[i] == "/")
                {
                    total = total / numbersArray[i + 1];
                }
            }
            DisplayResult.Text = total.ToString();
            for (int i = 0; i < 20; i++)
                numbersArray[i] = 0;
            for (int i = 0; i < 19; i++)
                operatorsArray[i] = "";
            storeVar = "";
            numbersCount = 0;
            operatorsCount = 0;
            total = 0;
            calculated = true;
        }

        private void Subtract_Click_1(object sender, RoutedEventArgs e)
        {
            setNumber(storeVar);
            setOperator("-");
            DisplayCalculation.Text += "-";
        }

        private void Add_Click_1(object sender, RoutedEventArgs e)
        {
            setNumber(storeVar);
            setOperator("+");
            DisplayCalculation.Text += "+";
        }

        private void Multiply_Click_1(object sender, RoutedEventArgs e)
        {
            setNumber(storeVar);
            setOperator("*");
            DisplayCalculation.Text += "*";
        }

        private void Divide_Click_1(object sender, RoutedEventArgs e)
        {
            setNumber(storeVar);
            setOperator("/");
            DisplayCalculation.Text += "/";
        }
    }
}
