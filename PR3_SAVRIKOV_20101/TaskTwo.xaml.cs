using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для TaskTwo.xaml
    /// </summary>
    public partial class TaskTwo : Window
    {
        public TaskTwo()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            string stringInput = textBoxInput.Text.Trim();
            stringInput = Regex.Replace(stringInput, @"\s+", " ");
            Regex regex = new Regex(@"[a-z]|[A-Z]|[1-9]");

            try
            {
                if (regex.IsMatch(stringInput) == true)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                labelResult.Content = "Вводите только русские буквы и пробелы";
                return;
            }

            ArrayList arrayList = new ArrayList();
            arrayList.AddRange(stringInput.Split(' '));

            int lengthLongest = 0;
            //string wordLongest = "";

            foreach(object word in arrayList)
            {
                if (word.ToString().Length > lengthLongest)
                {
                    lengthLongest = word.ToString().Length;
                    //wordLongest = word.ToString();
                }                    
            }

            if (lengthLongest == 0)
                labelResult.Content = "пусто";

            labelResult.Content = $"длина самого длинного слова = {lengthLongest}";
        }
    }
}
