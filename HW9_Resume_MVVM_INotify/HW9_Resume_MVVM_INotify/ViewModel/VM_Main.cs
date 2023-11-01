using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_Resume_MVVM_INotify.ViewModel
{
    internal class VM_Main:VM_Base
    {
        public ObservableCollection<VM_Resume> Resumes { get; set; }

        private VM_Resume _resume;
        public VM_Resume Current
        {
            get { return _resume; }
            set
            {
                _resume = value;
                OnPropertyChanged(nameof(Current));
            }
        }

        public VM_Main()
        {
            Current = new VM_Resume();
        }
    }
}
