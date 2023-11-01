using HW9_Resume_MVVM_INotify.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_Resume_MVVM_INotify.ViewModel
{
    public class VM_Main:VM_Base
    {
        public ObservableCollection<VM_Resume> Resumes { get; set; }
        private int sel;
        public int SelectedResume 
        { 
            get { return sel; }
            set
            {
                sel = value;
                Current = Resumes[sel];
                OnPropertyChanged(nameof(SelectedResume));
            }
        }

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
            Resumes = new ObservableCollection<VM_Resume>();
            GenerateDataService gem = new GenerateDataService();
            foreach (var item in gem.resume)
            {
                Resumes.Add(item);
            }
            sel = 1;
        }
    }
}
