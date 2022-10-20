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

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для auth.xaml
    /// </summary>
    public partial class auth : Window
    {
        public auth()
        {
            InitializeComponent();
        }

        private void Authorization_button(object sender, RoutedEventArgs e)
        {
            if (login_box.Text == "2")
            {
                if (password_box.Text == "2")
                {
                    MessageBox.Show("Результат Unit Тестирования:\nSuccess");
                    Close();
                }
                else MessageBox.Show("Результат Unit Тестирования:\nFailed");
            }
            else MessageBox.Show("Результат Unit Тестирования:\nFailed");
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            //auth auth = new auth();
            //auth.Show();
        }
    }
}
