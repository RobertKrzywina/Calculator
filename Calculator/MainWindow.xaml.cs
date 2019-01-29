using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            allCalculations.Add('0');
        }

        public static List<char> allCalculations = new List<char>();
        public static double result = 0.0;
        public static bool isDotAvailable = true;

        private void NumberZeroBtn_Click(object sender, RoutedEventArgs e)
        {
            allCalculations.Add('0');
            allCalculationsTextBox.AppendText("0");
        }

        private void NumberOneBtn_Click(object sender, RoutedEventArgs e)
        {
            changeZeroToAnyNumberIfNeeded();

            allCalculations.Add('1');
            allCalculationsTextBox.AppendText("1");
        }

        private void NumberTwoBtn_Click(object sender, RoutedEventArgs e)
        {
            changeZeroToAnyNumberIfNeeded();

            allCalculations.Add('2');
            allCalculationsTextBox.AppendText("2");
        }

        private void NumberThreeBtn_Click(object sender, RoutedEventArgs e)
        {
            changeZeroToAnyNumberIfNeeded();

            allCalculations.Add('3');
            allCalculationsTextBox.AppendText("3");
        }

        private void NumberFourBtn_Click(object sender, RoutedEventArgs e)
        {
            changeZeroToAnyNumberIfNeeded();

            allCalculations.Add('4');
            allCalculationsTextBox.AppendText("4");
        }

        private void NumberFiveBtn_Click(object sender, RoutedEventArgs e)
        {
            changeZeroToAnyNumberIfNeeded();

            allCalculations.Add('5');
            allCalculationsTextBox.AppendText("5");
        }

        private void NumberSixBtn_Click(object sender, RoutedEventArgs e)
        {
            changeZeroToAnyNumberIfNeeded();

            allCalculations.Add('6');
            allCalculationsTextBox.AppendText("6");
        }

        private void NumberSevenBtn_Click(object sender, RoutedEventArgs e)
        {
            changeZeroToAnyNumberIfNeeded();

            allCalculations.Add('7');
            allCalculationsTextBox.AppendText("7");
        }

        private void NumberEightBtn_Click(object sender, RoutedEventArgs e)
        {
            changeZeroToAnyNumberIfNeeded();

            allCalculations.Add('8');
            allCalculationsTextBox.AppendText("8");
        }

        private void NumberNineBtn_Click(object sender, RoutedEventArgs e)
        {
            changeZeroToAnyNumberIfNeeded();

            allCalculations.Add('9');
            allCalculationsTextBox.AppendText("9");
        }

        private void changeZeroToAnyNumberIfNeeded()
        {
            if (allCalculations.Count() == 1 && allCalculations[0] == '0')
            {
                allCalculationsTextBox.Clear();
            }
        }

        private void AdditionBtn_Click(object sender, RoutedEventArgs e)
        {
            if (allCalculations.Count() != 0 && !isLastElementEqualsMathAction())
            {
                allCalculations.Add('+');
                allCalculationsTextBox.AppendText("+");
                isDotAvailable = true;
            }
        }

        private void SubtractionBtn_Click(object sender, RoutedEventArgs e)
        {
            if (allCalculations.Count() != 0 && !isLastElementEqualsMathAction())
            {
                allCalculations.Add('-');
                allCalculationsTextBox.AppendText("-");
                isDotAvailable = true;
            }
        }

        private void MultiplicationBtn_Click(object sender, RoutedEventArgs e)
        {
            if (allCalculations.Count() != 0 && !isLastElementEqualsMathAction())
            {
                allCalculations.Add('*');
                allCalculationsTextBox.AppendText("*");
                isDotAvailable = true;
            }
        }

        private void DivisionBtn_Click(object sender, RoutedEventArgs e)
        {
            if (allCalculations.Count() != 0 && !isLastElementEqualsMathAction())
            {
                allCalculations.Add('/');
                allCalculationsTextBox.AppendText("/");
                isDotAvailable = true;
            }
        }

        private void DotBtn_Click(object sender, RoutedEventArgs e)
        {
            if (allCalculations.Count() != 0 && !isLastElementEqualsMathAction() && isDotAvailable == true)
            {
                allCalculations.Add('.');
                allCalculationsTextBox.AppendText(",");
                isDotAvailable = false;
            }
        }

        private void ModuloBtn_Click(object sender, RoutedEventArgs e)
        {
            if (allCalculations.Count() != 0 && !isLastElementEqualsMathAction())
            {
                allCalculations.Add('%');
                allCalculationsTextBox.AppendText("%");
            }
        }

        private Boolean isLastElementEqualsMathAction()
        {
            return allCalculations[allCalculations.Count - 1].Equals('+') ||
                   allCalculations[allCalculations.Count - 1].Equals('-') ||
                   allCalculations[allCalculations.Count - 1].Equals('*') ||
                   allCalculations[allCalculations.Count - 1].Equals('/') ||
                   allCalculations[allCalculations.Count - 1].Equals('.') ||
                   allCalculations[allCalculations.Count - 1].Equals('%');
        }

        private void EqualsBtn_Click(object sender, RoutedEventArgs e)
        {
            if (isContainMathActions() && isNotContainMathActions(allCalculations.Count - 1))
            {
                List<char> mathActions = new List<char>();
                List<double> numbers = new List<double>();

                var sb = new StringBuilder();

                for (int i = 0; i < allCalculations.Count; i++)
                {
                    if (isNotContainMathActions(i)) sb.Append(allCalculations[i]);
                    else if (sb.ToString().Contains('.'))
                    {
                        numbers.Add(double.Parse(sb.ToString(), System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo));
                        mathActions.Add(allCalculations[i]);
                        sb.Clear();
                    }
                    else
                    {
                        numbers.Add(Convert.ToDouble(sb.ToString()));
                        mathActions.Add(allCalculations[i]);
                        sb.Clear();
                    }
                }

                if (sb.ToString().Contains('.'))
                {
                    numbers.Add(double.Parse(sb.ToString(), System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo));
                    sb.Clear();
                }
                else if (sb != null)
                {
                    numbers.Add(Convert.ToDouble(sb.ToString()));
                    sb.Clear();
                }

                bool dividedByZero = false;
                result += numbers[0];

                for (int i = 1; i < numbers.Count; i++)
                {
                    switch (mathActions[i - 1])
                    {
                        case '+': result += numbers[i]; break;
                        case '-': result -= numbers[i]; break;
                        case '*': result *= numbers[i]; break;
                        case '/':
                            if (numbers[i] != 0) result /= numbers[i];
                            else
                            {
                                resultTextBox.Clear();
                                resultTextBox.AppendText("Do not divide by zero!");
                                dividedByZero = true;
                            }
                            break;
                        case '%': result %= numbers[i]; break;
                    }
                }

                if (dividedByZero == false)
                {
                    resultTextBox.Clear();
                    resultTextBox.AppendText(result.ToString());
                }
                else result = 0.0;

                dividedByZero = false;
                allCalculations.Clear();
                allCalculationsTextBox.Clear();
                allCalculations.Add('0');
                allCalculationsTextBox.AppendText(result.ToString());
                isDotAvailable = false;
            }
        }

        private bool isContainMathActions()
        {
            return allCalculations.Contains('+') ||
                   allCalculations.Contains('-') ||
                   allCalculations.Contains('*') ||
                   allCalculations.Contains('/') ||
                   allCalculations.Contains('%');
        }

        private bool isNotContainMathActions(int index)
        {
            return allCalculations[index] != '+' &&
                   allCalculations[index] != '-' &&
                   allCalculations[index] != '*' &&
                   allCalculations[index] != '/' &&
                   allCalculations[index] != '%';
        }

        private void DeleteAllBtn_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            allCalculationsTextBox.Clear();
            allCalculations.Clear();
            result = 0.0;
            resultTextBox.AppendText("0");
            allCalculationsTextBox.AppendText("0");
            allCalculations.Add('0');
            isDotAvailable = true;
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (allCalculations.Count != 1)
            {
                allCalculations.RemoveAt(allCalculations.Count - 1);
                allCalculationsTextBox.Text = allCalculationsTextBox.Text.Substring(0, (allCalculationsTextBox.Text.Length - 1));
            }

            if (String.IsNullOrEmpty(allCalculationsTextBox.Text)) allCalculationsTextBox.AppendText("0");
        }
    }
}
