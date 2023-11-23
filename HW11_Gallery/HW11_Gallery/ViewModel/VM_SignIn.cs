using HW11_Gallery.Model;
using HW11_Gallery.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Xml.Linq;
using HW11_Gallery.View;
using System.Windows.Navigation;
using NavigationService = HW11_Gallery.Service.NavigationService;

namespace HW11_Gallery.ViewModel
{
    public class VM_SignIn : VM_Base
    {
        private M_User user;
        public string Login
        {
            get { return user.Login; }
            set
            {
                user.Login = value;
                OnPropertyChanged(nameof(Login));
            }
        }
        public string Password
        {
            get { return user.Password; }
            set
            {
                user.Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public ICommand SignInCommand
        {
            get
            {
                if (SignIn == null)
                    SignIn = new DelegateCommand(ex => _SignIn(), ce => CanSignIn());
                return SignIn;
            }
        }
        private DelegateCommand SignIn;

        private bool CanSignIn()
        {
            return true;
        }
        private void _SignIn()
        {
            try
            {
                // ВАЛИДАЦИЯ
                if (Login.Length < 3 ||
                    Password.Length <= 8)
                {
                    throw new Exception("Fields must not be empty");
                }
                DataService.AuthenticateUser(Login, Password);

                App.Current.MainWindow.Hide();
                NavigationService.Instance.NavigateToPage<VM_Main>();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }
        }

        public VM_SignIn()
        {
            user = M_User.Instance;
        }
    }
}
