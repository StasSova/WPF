using HW9_Resume_MVVM_INotify.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_Resume_MVVM_INotify.ViewModel.TEMPLATE
{
    public class VM_Skill:VM_Base
    {
        private M_Skill Skill;
        public string SkillName 
        { 
            get {return Skill.Skill;} 
            set
            {
                Skill.Skill = value;
                OnPropertyChanged(nameof(Skill));
            }
        }

        public VM_Skill()
        {
            Skill = new M_Skill();
        }
    }
}
