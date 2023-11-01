using HW9_Resume_MVVM_INotify.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HW9_Resume_MVVM_INotify.ViewModel
{
    public class VM_Resume:VM_Base
    {
        private M_Resume model;
        public string ImageSource
        {
            get { return model.SourceImage; }
            set
            {
                model.SourceImage = value;
                OnPropertyChanged(nameof (ImageSource));
            }
        }
        public string FullName
        {
            get { return model.FullName; }
            set
            {
                model.FullName = value;
                OnPropertyChanged(nameof(FullName));
            }
        }
        public string Age
        {
            get { return model.Age; }
            set
            {
                model.Age = value;
                OnPropertyChanged(nameof(Age));
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
        public string Salary
        {
            get { return model.Salary; }
            set
            {
                model.Salary = value;
                OnPropertyChanged(nameof(Salary));
            }
        }
        public string Phone
        {
            get { return model.Phone; }
            set
            {
                model.Phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        public string Email
        {
            get { return model.Email; }
            set
            {
                model.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        
        public string ProffSkill
        {
            get { return model.ProffSkill; }
            set
            {
                model.ProffSkill = value;
                OnPropertyChanged(nameof(ProffSkill));
            }
        }
        public string CommSkill
        {
            get { return model.CommSkill; }
            set
            {
                model.CommSkill = value;
                OnPropertyChanged(nameof(CommSkill));
            }
        }





        

        public VM_Resume() 
        {
            model = new M_Resume();
        }
    }
}
