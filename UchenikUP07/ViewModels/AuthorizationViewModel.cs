using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UchenikUP07.ViewModels
{
    class AuthorizationViewModel : ViewModelBase
    {
        public static Account Account { get; private set; }

        public string Login { get; set; }

        public AuthorizationViewModel()
        {
            Title = "Авторизация";
        }
        public IGettingPassword GettingPassword { private get; set; }
        private string Password
        {
            get => GettingPassword.GetPassword();
        }
        public bool LogIn()
        {
            try
            {
                Account = DataBase.GetContext().Account.FirstOrDefault(p => p.Login == Login && p.Password == Password);

            }
            catch (Exception)
            {

            }
            return Account != null;

        }
    }
}
