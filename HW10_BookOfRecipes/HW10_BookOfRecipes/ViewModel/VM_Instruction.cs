using HW10_BookOfRecipes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_BookOfRecipes.ViewModel
{
    public class VM_Instruction:VM_Base
    {
        private M_Instruction model;

        public string Title
        {
            get { return model.Title; }
            set { model.Title = value; OnPropertyChanged(nameof(Title)); }
        }
        public string Description
        {
            get { return model.Description; }
            set { model.Description = value; OnPropertyChanged(nameof(Description)); }
        }

        public VM_Instruction(M_Instruction instruction) 
        { 
            model = instruction;
        }
    }
}
