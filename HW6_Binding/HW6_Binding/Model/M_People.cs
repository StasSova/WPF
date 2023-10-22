using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_Binding.Model
{
    [Serializable]
    public class M_People : INotifyPropertyChanged
    {
        private string _FullName;
        private string _Address;
        private string _NumberPhone;
        public string FullName
        {
            get { return _FullName; }
            set
            {
                _FullName = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(FullName)));
            }
        }
        public string Address
        {
            get { return _Address; }
            set
            {
                _Address = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Address)));
            }
        }
        public string NumberPhone
        {
            get { return _NumberPhone; }
            set
            {
                _NumberPhone = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(NumberPhone)));
            }
        }
        public M_People()
        {
            
        }
        public M_People(string FullName, string Address, string NumberPhone)
        {
            this.FullName = FullName;
            this.Address = Address;
            this.NumberPhone = NumberPhone;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            // вызываем только те события, которые касаются определенного поля
            PropertyChanged?.Invoke(this, e);
        }
    }
}
