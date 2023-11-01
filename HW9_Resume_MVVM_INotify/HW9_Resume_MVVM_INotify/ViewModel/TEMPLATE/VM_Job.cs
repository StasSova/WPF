using HW9_Resume_MVVM_INotify.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_Resume_MVVM_INotify.ViewModel.TEMPLATE
{
    public class VM_Job: VM_Base
    {
        private M_Job model;
        public  VM_Job() 
        { model = new M_Job(); }

        public string StartDate
        {
            get { return model.StartDate; }
            set 
            { 
                model.StartDate = value;
                OnPropertyChanged(nameof(StartDate));
            }
        }
        public string EndDate
        {
            get { return model.EndDate; }
            set 
            { 
                model.EndDate = value;
                OnPropertyChanged(nameof(EndDate));
            }
        }
        public string Company
        {
            get { return model.Company; }
            set 
            { 
                model.Company = value;
                OnPropertyChanged(nameof(Company));
            }
        }
        public string Post
        {
            get { return model.Post; }
            set 
            { 
                model.Post = value;
                OnPropertyChanged(nameof(Post));
            }
        }
        public string Description
        {
            get { return model.Description; }
            set 
            { 
                model.Description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
    }
}
