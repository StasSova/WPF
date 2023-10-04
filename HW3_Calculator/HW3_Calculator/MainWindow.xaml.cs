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

namespace HW3_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string currentNumber = "";
        private string previousExpression = "";
        private char lastOperation;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void UpdateDisplay()
        {
            // Обновление текстовых полей на форме
            txt_Prev.Text = previousExpression;
            txt_Curr.Text = currentNumber;
        }
        private void AddDigit(char digit)
        {
            // Попытка парсинга текущего числа на случай если там какой-то текст
            if (double.TryParse(currentNumber, out _))
            {
                // Если текущее число не 0, и нет точки, или текущее число пустое, добавляем число
                if (!(currentNumber == "0" && !currentNumber.Contains(".")) || currentNumber == "")
                {
                    currentNumber += digit;
                }
            }
            else
            {
                // Если текущее число не является числом, заменяем его на новую цифру
                currentNumber = digit.ToString();
            }
            UpdateDisplay();
        }
        private void AddDecimalPoint()
        {
            // Проверяем, чтобы избежать добавления лишней запятой
            if (!currentNumber.Contains(","))
            {
                // если число "пустое" -> добавляем 0
                if (currentNumber == "") currentNumber += "0";
                currentNumber += ",";
            }
            UpdateDisplay();
        }
        private void AddOperation(char operation)
        {
            // Выполнение операции над результатом предыдущей операции и текущим числом
            if (!string.IsNullOrEmpty(currentNumber))
            {
                // Если текущее число уже введено
                if (!string.IsNullOrEmpty(previousExpression))
                {
                    EvaluateExpression();
                }

                lastOperation = operation;
                previousExpression = currentNumber + " " + operation;
                currentNumber = "";
            }
            else
            {
                previousExpression = previousExpression.Remove(previousExpression.Length-1,1) + operation;
                lastOperation = operation;
            }
            UpdateDisplay();
        }
        private void EvaluateExpression()
        {
            try
            {
                // Вычисление выражения
                double num1 = double.Parse(currentNumber);
                double num2 = double.Parse(previousExpression.Substring(0, previousExpression.Length - 2));

                switch (lastOperation)
                {
                    case '+':
                        currentNumber = (num2 + num1).ToString();
                        break;
                    case '-':
                        currentNumber = (num2 - num1).ToString();
                        break;
                    case 'x':
                        currentNumber = (num2 * num1).ToString();
                        break;
                    case '÷':
                        if (num1 != 0)
                            currentNumber = (num2 / num1).ToString();
                        else 
                            currentNumber = "Деление на ноль невозможно.";
                        break;
                }

                previousExpression = "";
                lastOperation = '\0';
                UpdateDisplay();
            }
            catch(Exception ex) 
            {
                ClearAll();
                MessageBox.Show(ex.Message, ex.GetType().Name,MessageBoxButton.OK); 
            }
        }
        private void ButtonDigit_Click(object sender, RoutedEventArgs e)
        {
            // Обработка нажатия кнопок "0"-"9"
            Button button = (Button)sender;
            char digit = button.Content.ToString()[0];

            AddDigit(digit);
        }
        private void ButtonDecimal_Click(object sender, RoutedEventArgs e)
        {
            // Обработка нажатия кнопки "."
            AddDecimalPoint();
        }
        private void ButtonOperation_Click(object sender, RoutedEventArgs e)
        {
            // Обработка нажатия кнопок "/","*","+","-"
            Button button = (Button)sender;
            char operation = button.Content.ToString()[0];
            AddOperation(operation);
        }
        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            // Обработка нажатия кнопки "="
            if (previousExpression != "")
                EvaluateExpression();
        }
        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            // Обработка нажатия кнопки "CE"
            currentNumber = "";
            UpdateDisplay();
        }
        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            // Обработка нажатия кнопки "C"
            ClearAll();
        }
        private void ButtonBackspace_Click(object sender, RoutedEventArgs e)
        {
            // Обработка нажатия кнопки "<"
            if (!string.IsNullOrEmpty(currentNumber))
            {
                currentNumber = currentNumber.Substring(0, currentNumber.Length - 1);
                UpdateDisplay();
            }
        }
        private void ClearAll()
        {
            // Очистка всех полей и переменных
            currentNumber = "";
            previousExpression = "";
            lastOperation = '\0';
            UpdateDisplay();
        }
    }
}
