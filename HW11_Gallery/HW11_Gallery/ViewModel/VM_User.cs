using HW11_Gallery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_Gallery.ViewModel
{
    public class VM_User:VM_Base
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
        public VM_User() 
        {
            user = M_User.Instance;
        }
    }
}
