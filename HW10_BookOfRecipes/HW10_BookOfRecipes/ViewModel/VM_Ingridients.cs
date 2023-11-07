using HW10_BookOfRecipes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_BookOfRecipes.ViewModel
{
    public class VM_Ingridients: VM_Base
    {
        private M_Ingridients model;
        public string Name
        {
            get { return model.Name; }
            set { model.Name = value; OnPropertyChanged(nameof(Name)); }
        }
        public string Count
        {
            get { return model.Count; }
            set { model.Count = value; OnPropertyChanged(nameof(Count)); }
        }
        public VM_Ingridients() 
        { 
            model = new M_Ingridients();
        }
        public VM_Ingridients(M_Ingridients recipe)
        {
            model = recipe;
        }
    }
}
