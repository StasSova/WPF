using HW9_Resume_MVVM_INotify.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_Resume_MVVM_INotify.ViewModel.TEMPLATE
{
    public class VM_Language:VM_Base
    {
        private M_Language lang;
        public M_Language Lang
        {
            get { return lang; }
            set
            {
                lang = value; OnPropertyChanged(nameof(Lang));
            }
        }
        public VM_Language() { lang = new M_Language(); }

        public string Language { get { return lang.Language; } set { lang.Language = value; OnPropertyChanged(nameof(Language)); } }
        public int Level 
        { 
            get 
            { 
                return lang.Level; 
            } 
            set 
            { 
                lang.Level = value; 
                OnPropertyChanged(nameof(Level)); 
            } 
        }
    }
}
