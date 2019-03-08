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

namespace BrowserHistory_Server
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const short MIN_LENGTH = 5;

        public MainWindow()
        {
            InitializeComponent();
        }


        // Изменение цвета при вводе данных
        //private void Login_TextBox_TextInput(object sender, TextChangedEventArgs e)
        //{
        //    if (Login_TextBox.Text.Length < MIN_LENGTH)
        //        Login_TextBox.Background = Brushes.Red;
        //    else
        //        Login_TextBox.Background = Brushes.Green;
        //}

        //private void Password_PasswordBox_PasswordInput(object sender, RoutedEventArgs e)
        //{
        //    if (Password_PasswordBox.Password.Length < MIN_LENGTH)
        //        Password_PasswordBox.Background = Brushes.Red;
        //    else
        //        Password_PasswordBox.Background = Brushes.Green;
        //}

        // Открывает рабочее окно
        private void Sign_in_Button_Input(object sender, RoutedEventArgs e)
        {
            Work_Window work_Window = new Work_Window();
            work_Window.Show();
        }

        //Закрытие окна входа
        private void Closed_Button_Input(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
