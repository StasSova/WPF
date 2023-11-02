using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_Resume_MVVM_INotify.Model
{
    [Serializable]
    public class M_Skill
    {
        public string Skill;
        public M_Skill() 
        {
            Skill = "Your Skill";
        }
    }
}
