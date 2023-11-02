using HW9_Resume_MVVM_INotify.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_Resume_MVVM_INotify.Model
{
    [Serializable]
    public class M_Contact
    {
        public string Info;
        public M_Contact() 
        {
            Info = "UNKNOWN";
        }

    }
}
