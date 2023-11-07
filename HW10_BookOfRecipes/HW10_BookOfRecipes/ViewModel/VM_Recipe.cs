using HW10_BookOfRecipes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HW10_BookOfRecipes.ViewModel
{
    public class VM_Recipe: VM_Base
    {
        private M_Recipe model;
        public string Title
        {
            get
            {
                return model.Title;
            }
            set
            {
                model.Title = value;
                OnPropertyChanged(nameof(Title));
            }
        }
        public string Description
        {
            get
            {
                return model.Description;
            }
            set
            {
                model.Description = value;
                OnPropertyChanged(nameof(Title));
            }
        }
        public string ImageSource
        {
            get
            {
                return model.ImageSource;
            }
            set
            {
                model.ImageSource = value;
                OnPropertyChanged(nameof(ImageSource));
            }
        }
        private List<VM_Ingridients> ingredients;
        public List<VM_Ingridients> Ingredients 
        {
            get {return ingredients; }
            set
            {
                ingredients = value;
                OnPropertyChanged(nameof(Ingredients));
            }
        }

        private List<VM_Instruction> _instruction;
        public List<VM_Instruction> Instruction
        {
            get { return _instruction; }
            set
            {
                _instruction = value;
                OnPropertyChanged(nameof(Description));
            }
        }
        public VM_Recipe(M_Recipe recipe) 
        {
            model = recipe;
            
            Ingredients = new List<VM_Ingridients>();
            foreach (var rec in model.Ingredients)
                Ingredients.Add(new VM_Ingridients(rec));
            
            Instruction = new List<VM_Instruction>();
            foreach (var item in model.Instructions)
                Instruction.Add(new VM_Instruction(item));
        }
    }
}
