using HW9_Resume_MVVM_INotify.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_Resume_MVVM_INotify.ViewModel.TEMPLATE
{
    public class VM_Contact: VM_Base
    {
        private M_Contact _contact;
        public M_Contact Contact
        {
            get { return _contact; }
            set 
            { 
                _contact = value; 
                OnPropertyChanged(nameof(Contact));
            }

        }
        public string Info
        {
            get { return _contact.Info; }
            set
            {
                _contact.Info = value;
                OnPropertyChanged(nameof(Info));
            }
        }
        public VM_Contact()
        {
            _contact = new M_Contact();
        }
    }
}
