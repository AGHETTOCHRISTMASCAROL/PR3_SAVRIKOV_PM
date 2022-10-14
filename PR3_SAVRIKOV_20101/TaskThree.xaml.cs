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
    /// Логика взаимодействия для TaskThree.xaml
    /// </summary>
    public partial class TaskThree : Window
    {
        public TaskThree()
        {
            InitializeComponent();
        }

        private Random _random = new Random();
        private int _arrayLen = 3;

        private void OnClickGetResult(object sender, RoutedEventArgs e)
        {
            double[] xCoordinates = new double[_arrayLen];
            int i = 0;
            while(i < _arrayLen)
            {
                xCoordinates[i] = _random.Next(-2, 3);
                i++;
            }

            string vector = "";
            foreach(double x in xCoordinates)
            {
                vector += $"{x}  ";
            }
            lblArrayView.Content = vector;

            Activity activity = new Activity();
            lblResult.Content = $"Точка: {activity.GetResult(xCoordinates).Item1}\nМинимальная сумма = {activity.GetResult(xCoordinates).Item2}";
        }
    }

    public class Activity
    {
        public double LenBetween(double point1, double point2)
        {
            return Math.Abs(point2 - point1);
        }

        public Tuple<double, double> GetResult(double[] array)
        {
            double sum = 0;
            double minSum = double.MaxValue;
            double point = 0;

            foreach (double x in array)
            {
                foreach (double otherX in array)
                {
                    if (otherX == x)
                        continue;
                    sum += LenBetween(x, otherX);
                }

                if (sum < minSum)
                {
                    minSum = sum;
                    point = x;
                }
                sum = 0;
            }

            return Tuple.Create(point, minSum);
        }
    }
}