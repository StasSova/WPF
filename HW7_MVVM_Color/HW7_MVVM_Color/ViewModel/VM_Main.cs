using HW7_MVVM_Color.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace HW7_MVVM_Color.ViewModel
{
    public class VM_Main:VM_Base
    {
        public ObservableCollection<VM_Color> ColorList { get; set; }
        private VM_Color _color;
        public VM_Color CurrentColor 
        { 
            get {  return _color; }
            set 
            {  
                _color = value;
                OnPropertyChanged(nameof(CurrentColor));
            }
        }
        public VM_Main() 
        { 
            ColorList = new ObservableCollection<VM_Color>();
            CurrentColor = new VM_Color();
        }


        // ADD
        public ICommand AddCommand
        {
            get
            {
                if (_add == null)
                    _add = new DelegateCommand(exec => Add(), pred => CanAdd());
                return _add;
            }
        }
        private DelegateCommand _add;
        private bool CanAdd()
        {
            if (ColorList.Count == 0) return true;
            return !ColorList.Any(x =>   x.A == CurrentColor.A && 
                                        x.R == CurrentColor.R &&
                                        x.G == CurrentColor.G &&
                                        x.B == CurrentColor.B);
        }
        private void Add()
        {
            ColorList.Add(CurrentColor.Clone());
        }

        // SELECTED INDEX
        public int Index { get; set; }
        // REMOVE
        public ICommand RemoveCommand
        {
            get
            {
                if (_remove == null) _remove = new DelegateCommand(exec => Remove(), can => CanRemove());
                return _remove;
            }
        }
        private DelegateCommand _remove;
        private bool CanRemove()
        {
            return Index != -1;
        }
        private void Remove() 
        {
            ColorList.Remove(ColorList[Index]);
        }


    }
}
