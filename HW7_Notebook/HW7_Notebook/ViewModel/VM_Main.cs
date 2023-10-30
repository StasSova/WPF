using HW7_Notebook.Model;
using HW7_Notebook.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HW7_Notebook.ViewModel
{
    public class VM_Main: DependencyObject
    {
        public ObservableCollection<VM_Contact> contacts {  get; set; }
        public VM_Contact current { get; set; }
        private static readonly DependencyProperty _selectedIndexProperty;
        public int SelectedIndex
        {
            get { return (int)GetValue(_selectedIndexProperty); }
            set { SetValue(_selectedIndexProperty, value); }
        }
        public VM_Main()
        {
            SelectedIndex = -1;
            current = new VM_Contact();
            contacts = new ObservableCollection<VM_Contact>();
            LoadPeople();
        }
        static VM_Main() 
        { 
            _selectedIndexProperty = DependencyProperty.Register(nameof(SelectedIndex), typeof(int), typeof(VM_Main));
        }

        #region Commands
        // ADD PEOPLE
        private DelegateCommand? _addPeople;
        private void AddPeople()
        {
            contacts.Add(current.Clone());
        }
        private bool CanAddPeople()
        {
            return !current.IsEmpty();
        }
        public ICommand AddPeopleCommand
        {
            get
            {
                if (_addPeople == null) 
                    _addPeople = new DelegateCommand(ex => AddPeople(), ce => CanAddPeople());
                return _addPeople;
            }
        }

        // REMOVE PEOPLE
        private DelegateCommand? _removePeople;
        private void RemovePeople() 
        {
            contacts.RemoveAt(SelectedIndex);
        }
        private bool CanRemovePeople()
        {
            return SelectedIndex != -1;
        }
        public ICommand RemovePeopleCommand
        {
            get
            {
                if (_removePeople == null)
                    _removePeople = new DelegateCommand(ex => RemovePeople(), ce => CanRemovePeople());
                return _removePeople;
            }
        }

        // UPDATE PEOPLE
        private DelegateCommand? _updatePeople;
        private void UpdatePeople()
        {
            VM_Contact selected = contacts[SelectedIndex];
            if (selected == null) return;
            selected.Copy(current);
        }
        private bool CanUpdatePeople() 
        { 
            return !current.IsEmpty() && SelectedIndex != -1;
        }
        public ICommand UpdatePeopleCommand
        {
            get
            {
                if(_updatePeople == null)
                    _updatePeople = new DelegateCommand(ex=> UpdatePeople(), ce => CanUpdatePeople());
                return _updatePeople;
            }
        }
        #endregion

        // SAVE NOTEBOOK
        private DelegateCommand? _savePeoples;
        private void SavePeople() 
        {
            List<M_Contact> modelContacts = contacts.Select(vmContact => new M_Contact
            {
                FullName = vmContact.FullName,
                Address = vmContact.Address,
                Number = vmContact.Number
            }).ToList();

            DataService.Instance.Save(modelContacts);
        }
        private bool CanSavePeople() 
        { 
            return contacts.Count > 0;
        }
        public ICommand SavePeopleCommand
        {
            get
            {
                if (_savePeoples == null)
                    _savePeoples = new DelegateCommand(ex=> SavePeople(), ce => CanSavePeople());
                return _savePeoples;
            }
        }

        // LOAD COLLECTION
        private void LoadPeople()
        {
            List<M_Contact> modelContacts = DataService.Instance.GetCollection();
            if (modelContacts == null) return;
            if (modelContacts.Count == 0) return; 
            contacts.Clear();
            foreach (M_Contact modelContact in modelContacts)
            {
                VM_Contact vmContact = new VM_Contact
                {
                    FullName = modelContact.FullName,
                    Address = modelContact.Address,
                    Number = modelContact.Number
                };
                contacts.Add(vmContact);
            }
        }
    }
}
