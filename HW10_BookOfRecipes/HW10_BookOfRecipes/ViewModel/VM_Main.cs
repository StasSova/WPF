using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace HW10_BookOfRecipes.ViewModel
{
    public class VM_Main: VM_Base
    {
        public ObservableCollection<VM_Recipe> Recipes { get; set; }
        private VM_Recipe current;
        public VM_Recipe Current
        {
            get { return current; }
            set
            {
                current = value;
                OnPropertyChanged(nameof(Current));
            }
        }
        private int selectedIndex;
        public int SelectedIndex
        {
            get { return selectedIndex; } 
            set 
            { 
                selectedIndex = value;
                if (selectedIndex > -1)
                    Current = Recipes[selectedIndex];
                OnPropertyChanged(nameof(SelectedIndex));
            }
        }
        public VM_Main() 
        {
            Recipes = new ObservableCollection<VM_Recipe>();
            List<VM_Recipe> l = DataGenerator.GetM_Recipes().Select(x => new VM_Recipe(x)).ToList();
            foreach (VM_Recipe recipe in l) 
            { 
                Recipes.Add(recipe);
            }
            Current = Recipes[0];
        }
    }
}
