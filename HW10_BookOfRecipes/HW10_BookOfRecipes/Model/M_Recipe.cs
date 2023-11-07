using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HW10_BookOfRecipes.Model
{
    public class M_Recipe
    {
        public string Title;
        public string Description;
        public List<M_Instruction> Instructions;
        public List<M_Ingridients> Ingredients;
        public string ImageSource;
        public M_Recipe()
        {
            Title = "Title";
            Description = "Description";
            Ingredients = new List<M_Ingridients>();
            Instructions = new List<M_Instruction>();
            ImageSource = string.Empty;
        }
    }
}
