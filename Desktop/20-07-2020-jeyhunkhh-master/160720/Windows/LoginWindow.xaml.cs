using _160720.Models;
using _160720.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _160720.Windows
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly UserService _userService;
        public LoginWindow()
        {
            _userService = new UserService();

            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            LblMessage.Visibility = Visibility.Hidden;
            LblMessage.Content = string.Empty;

            string username = TxtUsername.Text;
            string password = TxtPassword.Password;

            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                LblMessage.Content = "İstifadəçi adı vəya şifrə boş olmamalıdır";
                LblMessage.Visibility = Visibility.Visible;
                return;
            }


            User user = _userService.Login(username, password);

            if(user == null)
            {
                LblMessage.Content = "İstifadəçi adı vəya şifrə yanlış";
                LblMessage.Visibility = Visibility.Visible;
                return;
            }

            DashboardWindow dashboardWindow = new DashboardWindow();
            dashboardWindow.Show();

            this.Close();
        }
    }
}
