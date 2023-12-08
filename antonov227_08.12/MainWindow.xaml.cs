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

namespace antonov227_08._12
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(aa.Text);
            int y = Convert.ToInt32(ss.Text);
            int count = 0;

            for (int i = x; i <= y; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
                MessageBox.Show($"Количество нечетных чисел на отрезке [{x},{y}]: {count}");
            }
        }
    }
}
