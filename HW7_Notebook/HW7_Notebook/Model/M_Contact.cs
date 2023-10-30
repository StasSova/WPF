using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HW7_Notebook.Model
{
    [Serializable]
    public class M_Contact: DependencyObject
    {
        private static readonly DependencyProperty FullNameProperty;
        private static readonly DependencyProperty AddressProperty;
        private static readonly DependencyProperty NumberProperty;
        public string FullName 
        {
            get {  return (string)GetValue(FullNameProperty); } 
            set {  SetValue(FullNameProperty, value); }
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
        static M_Contact() 
        {
            FullNameProperty = DependencyProperty.Register(nameof(FullName), typeof(string), typeof(M_Contact));
            AddressProperty = DependencyProperty.Register(nameof(Address), typeof(string), typeof(M_Contact));
            NumberProperty = DependencyProperty.Register(nameof(Number), typeof(string), typeof(M_Contact));    
        }
        public M_Contact Clone()
        {
            M_Contact clonedContact = new M_Contact
            {
                FullName = this.FullName,
                Address = this.Address,
                Number = this.Number
            };
            return clonedContact;
        }
    }

}
