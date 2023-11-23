using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HW11_Gallery.Model
{
    public class M_User
    {
        [NonSerialized]
        private static M_User _instance;
        public static M_User Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new M_User();
                return _instance;
            }
        }
        public string Login;
        public string Password;
        public string Name;
        public string Surname;
        private M_User() 
        {
            Login = string.Empty;
            Password = string.Empty;
            Name = string.Empty;
            Surname = string.Empty;
        }
    }
}
