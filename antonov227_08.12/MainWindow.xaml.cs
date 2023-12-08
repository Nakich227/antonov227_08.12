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


        private void BtnAdd_Click_1(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(TbNumber.Text)))
            {
                return;
            }
            try
            {
                int xa = Convert.ToInt32(TbNumber.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ListBoxDataa.Items.Add(TbNumber.Text);
        }

        private void BtnOK_Click_1(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(ListBoxDataa.Items[0]); 
            int b = 0;  
            for (int i = 1; i <= a; i++)
            {
                int m = Convert.ToInt32(ListBoxDataa.Items[i]);
                if (m % 3 == 0 && m % 10 == 4)
                {
                    b += m;
                }
            }
            if (b > 0)
            {
                TextBlockAnswer.Text = $"ответ:\n{b}";
            }
            else
            {
                TextBlockAnswer.Text = $"ответ:\n чисел оканчивающихсяна 4 и кратных 3 нету";
            }
        }

        private void BtnCancel_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
