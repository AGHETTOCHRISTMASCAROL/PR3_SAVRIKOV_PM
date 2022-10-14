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

namespace PR3_SAVRIKOV_20101
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TaskOne_click(object sender, RoutedEventArgs e) //переход на форму с первым заданием
        {
            TaskOne form = new TaskOne();
            form.ShowDialog();
        }

        private void TaskTwo_click(object sender, RoutedEventArgs e) // переход на форму со вторым заданием
        {
            TaskTwo form = new TaskTwo();
            form.ShowDialog();
        }

        private void TaskThree_Click(object sender, RoutedEventArgs e)
        {
            TaskThree form = new TaskThree();
            form.ShowDialog();
        }

        private void TaskFour_Click(object sender, RoutedEventArgs e)
        {
            TaskFour form = new TaskFour();
            form.ShowDialog();
        }
    }
}
