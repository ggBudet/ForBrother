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
using UchenikUP07.ViewModels;

namespace UchenikUP07
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window , IGettingPassword
    {
        public string GetPassword() => _passwordBox.Password;
        public Auth()
        {
            InitializeComponent();
            (DataContext as AuthorizationViewModel).GettingPassword = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if ((DataContext as AuthorizationViewModel).LogIn())
            { 
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
                MessageBox.Show($"Добро пожаловать,{AuthorizationViewModel.Account.Name}");
            }
            else MessageBox.Show("Неверный логин или пароль");
        }
    }
}
