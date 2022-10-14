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
    /// Логика взаимодействия для TaskFour.xaml
    /// </summary>
    public partial class TaskFour : Window
    {
        public TaskFour()
        {
            InitializeComponent();
        }

        private Random _random = new Random();
        private int _arrayLen = 10;

        private void onClickLetsSwap(object sender, RoutedEventArgs e)
        {
            string arrayView = "";
            double[] numbers = new double[_arrayLen];
            int i = 0;
            while (i < _arrayLen)
            {
                numbers[i] = _random.Next(-20, 20);
                arrayView += $"{numbers[i]}\t";
                i++;
            }
            lblStartArray.Content = arrayView;

            TaskFourActivity activity = new TaskFourActivity();
            double[] numbersSwap = activity.Swap(numbers);

            arrayView = "";

            foreach (double n in numbersSwap)
            {
                arrayView += $"{n}\t";
            }
            lblResultArray.Content = arrayView;
        }
    }

    public class TaskFourActivity
    {
        public double[] Swap(double[] array)
        {
            int firstEvenIndex = -1;
            int lastMinusIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    firstEvenIndex = i;
                    break;
                }
            }

            for (int j = array.Length - 1; j >= 0; j--)
            {
                if (array[j] < 0)
                {
                    lastMinusIndex = j;
                    break;
                }
            }         

            try
            {
                double temp = array[firstEvenIndex];
                array[firstEvenIndex] = array[lastMinusIndex];
                array[lastMinusIndex] = temp;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Массив не содержит четных или отрицательных элементов");
            }

            return array;
        }
    }
}
