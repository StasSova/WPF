using HW6_Binding.Model;
using HW6_Binding.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Navigation;

namespace HW6_Binding.ViewModel
{
    internal class VM_ListPeoples: INotifyPropertyChanged
    {
        // LIST OF PEOPLES
        private ObservableCollection<M_People> _Peoples = new ObservableCollection<M_People>();
        public ObservableCollection<M_People> Peoples
        {
            get { return _Peoples; }
            set { _Peoples = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(Peoples))); }
        }

        // FIELDS THAT DISPLAY AS DETAILED INFORMATION ABOUT PEOPLE
        private string _FullName;
        private string _Address;
        private string _NumberPhone;
        public string FullNamePeople
        {
            get { return _FullName; }
            set
            {
                _FullName = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(FullNamePeople)));
            }
        }
        public string AddressPeople
        {
            get { return _Address; }
            set
            {
                _Address = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(AddressPeople)));
            }
        }
        public string NumberPhonePeople
        {
            get { return _NumberPhone; }
            set
            {
                _NumberPhone = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(NumberPhonePeople)));
            }
        }

        // Field that is used for indication in the array
        private int index_selected_listbox = -1;
        public int Index_selected_listbox
        {
            get { return index_selected_listbox; }
            set
            {
                index_selected_listbox = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(index_selected_listbox)));
            }
        }

        public VM_ListPeoples()
        {
            // Initialize data
            LoadData();
        }
        void LoadData()
        {
            List<M_People> collection = DataService.Instance.GetCollection();
            if (collection == null) return;
            foreach (M_People people in collection)
            {
                Peoples.Add(people);
            }
        }


        // Selection changed
        public void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (Index_selected_listbox == -1) return;

                M_People people = Peoples[Index_selected_listbox];
                if (people == null) return;

                // присваиваем свойства выбранного человека
                FullNamePeople = people.FullName;
                AddressPeople = people.Address;
                NumberPhonePeople = people.NumberPhone;
            }
            catch (Exception ex) { }
        }
        // State changes
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            // вызываем только те события, которые касаются определенного поля
            PropertyChanged?.Invoke(this, e);
        }
        // Add people to List
        private DelegateCommand _AddPeople;
        public ICommand AddPeople
        {
            get
            {
                if (_AddPeople == null)
                    _AddPeople = new DelegateCommand(parem => AddPeopleToList(),canExecute => CanAdd());
                return _AddPeople;
            }
        }
        private bool CanAdd()
        {
            return !string.IsNullOrEmpty(FullNamePeople) &&
                   !string.IsNullOrEmpty(AddressPeople) &&
                   !string.IsNullOrEmpty(NumberPhonePeople);
        }
        private void AddPeopleToList()
        {
            if (string.IsNullOrEmpty(FullNamePeople) ||
                   string.IsNullOrEmpty(AddressPeople) ||
                   string.IsNullOrEmpty(NumberPhonePeople))
                return;

            Peoples.Add(new M_People(FullNamePeople, AddressPeople, NumberPhonePeople));
        }
        // Remove people from List
        private DelegateCommand _RemovePeople;
        public ICommand RemovePeople
        {
            get
            {
                if (_RemovePeople == null)
                    _RemovePeople = new DelegateCommand(param => RemovePeopleFromList(), canExecute => CanRemove());
                return _RemovePeople;
            }
        }
        private bool CanRemove()
        {
            return Index_selected_listbox != -1;
        }
        private void RemovePeopleFromList() 
        { 
            Peoples.Remove(Peoples[index_selected_listbox]);
        }
        // Update the selected person's information
        private DelegateCommand _UpdateInforamtion;
        public ICommand UpdateInforamtion
        {
            get
            {
                if (_UpdateInforamtion == null)
                    _UpdateInforamtion = new DelegateCommand(param => UpdateInformation(), canExecute => true);
                return _UpdateInforamtion;
            }
        }
        private void UpdateInformation()
        {
            if (Index_selected_listbox == -1) return;
            M_People people = Peoples[Index_selected_listbox];
            if (people == null) return;
            people.FullName = FullNamePeople;
            people.Address = AddressPeople;
            people.NumberPhone = NumberPhonePeople;
        }
        // Save peoples to file
        private DelegateCommand _SaveInformation;
        public ICommand SaveInformation
        {
            get
            {
                if (_SaveInformation == null)
                    _SaveInformation = new DelegateCommand(
                        param => SaveInfomationToFile(), 
                        canExecute => CanSave());
                return _SaveInformation;
            }
        }
        private bool CanSave()
        {
            return true;
        }
        private void SaveInfomationToFile()
        {
            if (Peoples.Count > 0)
                DataService.Instance.Save(Peoples.ToList());
        }

    }


}
