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
using System.Windows.Shapes;

namespace PR3_SAVRIKOV_20101
{
    /// <summary>
    /// Логика взаимодействия для TaskOne.xaml
    /// </summary>
    public partial class TaskOne : Window
    {
        public TaskOne()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            int number;

            try
            {
                number = int.Parse(textBoxInputNumber.Text);

                if (number < -999 || number > 999)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                labelResult.Content = "Введите целое число от -999 до 999!";
                return;
                throw;
            }

            int numberLength = number.ToString().Length;
            string stringResult;

            if(number < 0)
            {
                numberLength--;
                stringResult = "Отрицательное ";
            }

            else if(number > 0)
            {
                stringResult = "положительное ";
            }

            else
            {
                stringResult = "нулевое число";
            }

            switch (numberLength)
            {
                case 1: stringResult += "однозначное "; break;
                case 2: stringResult += "двузначное "; break;
                case 3: stringResult += "трехзначное "; break;
                default: break;
            }

            stringResult += "число";

            labelResult.Content = stringResult;
        }
    }
}
