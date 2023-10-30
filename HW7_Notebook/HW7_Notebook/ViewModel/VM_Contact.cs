using HW7_Notebook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HW7_Notebook.ViewModel
{
    public class VM_Contact: DependencyObject
    {
        private M_Contact _contact;
        private static readonly DependencyProperty FullNameProperty;
        private static readonly DependencyProperty AddressProperty;
        private static readonly DependencyProperty NumberProperty;
        public string FullName
        {
            get { return (string)GetValue(FullNameProperty); }
            set { SetValue(FullNameProperty, value); }
        }
        public string Address
        {
            get { return (string)GetValue(AddressProperty); }
            set { SetValue(AddressProperty, value); }
        }
        public string Number
        {
            get { return (string)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }
        static VM_Contact()
        {
            FullNameProperty = DependencyProperty.Register(nameof(FullName), typeof(string), typeof(VM_Contact), new PropertyMetadata(string.Empty, OnNameChanged));
            AddressProperty = DependencyProperty.Register(nameof(Address), typeof(string), typeof(VM_Contact), new PropertyMetadata(string.Empty, OnAddressChanged));
            NumberProperty = DependencyProperty.Register(nameof(Number), typeof(string), typeof(VM_Contact), new PropertyMetadata(string.Empty, OnNumberChanged));
        }
        private static void OnNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var vm = (VM_Contact)d;
            vm._contact.FullName = (string)e.NewValue;
        }
        private static void OnAddressChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var vm = (VM_Contact)d;
            vm._contact.Address = (string)e.NewValue;
        }
        private static void OnNumberChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var vm = (VM_Contact)d;
            vm._contact.Number = (string)e.NewValue;
        }

        public VM_Contact()
        {
            _contact = new M_Contact();
        }
        public VM_Contact(M_Contact contact)
        {
            _contact = contact;
        }
        public VM_Contact Clone()
        {
            VM_Contact contact = new VM_Contact();
            contact.FullName = FullName;
            contact.Address = Address;
            contact.Number = Number;
            return contact;
        }
        public void Copy(VM_Contact contact)
        {
            FullName = contact.FullName;
            Address = contact.Address;
            Number = contact.Number;
        }
        public bool IsEmpty()
        {
            return (string.IsNullOrEmpty(FullName)||
                    string.IsNullOrEmpty(Address)||
                    string.IsNullOrEmpty(Number));
        }
    }
}
