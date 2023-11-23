using HW11_Gallery.Model;
using HW11_Gallery.Service;
using HW11_Gallery.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HW11_Gallery.ViewModel
{
    public class VM_SignUp:VM_Base
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
        private string repPass;
        public string RepeatPassword
        {
            get { return repPass; }
            set
            {
                repPass = value;
                OnPropertyChanged(nameof(RepeatPassword));
            }
        }
        public string Name
        {
            get { return user.Name; }
            set
            {
                user.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Surname
        {
            get { return user.Surname; }
            set
            {
                user.Surname = value;
                OnPropertyChanged(nameof(Surname));
            }
        }
        public ICommand SignUpCommand
        {
            get
            {
                if (SignUp == null)
                    SignUp = new DelegateCommand(ex => Sign(), ce => CanSignUp());
                return SignUp;
            }
        }
        private DelegateCommand SignUp;
        
        private bool CanSignUp()
        {
            return true;
        }
        private void Sign()
        {
            // ВАЛИДАЦИЯ
            if (Surname.Length < 3 ||
                Name.Length < 3 ||
                Login.Length < 3 || 
                Password.Length <= 8)
            {
                MessageBox.Show("Fields must not be empty", "Error", MessageBoxButton.OK);
                return;
            }
            if(Password != RepeatPassword)
            {
                MessageBox.Show("Password mismatch", "Error", MessageBoxButton.OK);
                return;
            }
            // Проверка, существует ли пользователь с таким логином
            if (DataService.UserExistsInFile(Login))
            {
                MessageBox.Show("Пользователь с таким логином уже существует.", "Error", MessageBoxButton.OK);
                return;
            }
            // СОХРАНЕНИЕ В БД
            DataService.Save(user);

            App.Current.MainWindow.Hide();
            NavigationService.Instance.NavigateToPage<VM_Main>();
        }

        public VM_SignUp() 
        {
            user = M_User.Instance;
        }
    }
}
