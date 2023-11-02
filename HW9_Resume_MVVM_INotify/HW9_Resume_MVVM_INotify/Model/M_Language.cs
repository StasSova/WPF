using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_Resume_MVVM_INotify.Model
{
    [Serializable]
    public class M_Language
    {
        public string Language;
        public int Level; 

        public M_Language() 
        { 
            Language = "LANGUAGE";
            Level = 1;
        }
    }
}
