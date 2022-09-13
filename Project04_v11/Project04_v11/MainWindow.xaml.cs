using System;
using System.Windows;

namespace Project04_v11
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

        private void btn_Result_Click(object sender, RoutedEventArgs e)
        {
            tbk_result.Text = "";

            for (int i = Convert.ToInt32(tb_A.Text); i <= Convert.ToInt32(tb_B.Text); i++)
            {
                if (IsPerfect(i))
                {
                    if (tbk_result.Text == "")
                        tbk_result.Text += $"{i}";
                    else
                        tbk_result.Text += $"+{i}";
                }
            }
        }

        private bool IsPerfect(int n)
        {
            int sum = 1;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            return sum == n;
        }
    }
}
