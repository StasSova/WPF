using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace HW6_Binding
{
    /*
    Используя привязку данных, реализуйте приложение «записная
    книжка». отвечающее следующим требованиям.
    • Записная книжка должна хранить ФИО человека, его адрес и
    телефон.
    • Обеспечить возможность добавления, удаления и модификации
    записей.
    • Обеспечить вОЗмОжнОСтЬ сохранения данных в файл и загрузку
    данных из файла.
     */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                LoadFromFile();
            }
            catch (Exception ex) { }
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                // достаем указатель на ресурс
                ListOfPeoples list  = Resources["ListOfPeople"] as ListOfPeoples;
                // если там что то есть и список не пуст
                if (list != null && list.Index_selected_listbox == -1) 
                { return; }

                // достаем выбранного человека
                People people = list.Peoples[list.Index_selected_listbox];

                // присваиваем свойства выбранного человека
                list.FullNamePeople = people.FullName;
                list.AddressPeople = people.Address;
                list.NumberPhonePeople = people.NumberPhone;

            }
            catch (Exception ex) { }
        }
        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // достаем указатель на ресурс
                ListOfPeoples list = Resources["ListOfPeople"] as ListOfPeoples;
                if (list != null && list.Peoples.Count == 0)
                { return; }
                FileStream stream = new FileStream("../../list.xml", FileMode.Create);
                XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<People>));
                serializer.Serialize(stream, list.Peoples);
                stream.Close();
            }
            catch { }

        }
        private void LoadFromFile()
        {
            try
            {
                FileStream stream = new FileStream("../../list.xml", FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<People>));
                ListOfPeoples list = Resources["ListOfPeople"] as ListOfPeoples;

                ObservableCollection<People> deserializedPeople = (ObservableCollection<People>)serializer.Deserialize(stream);

                list.Peoples.Clear();  // Очистить старые данные

                foreach (var person in deserializedPeople)
                {
                    list.Peoples.Add(person);  // Добавить новые данные
                }

                if (list.Peoples.Count == 1) { return; }

                People last = list.Peoples.Last();
                if (!last.Equals(new People()))
                {
                    list.AddressPeople = last.Address;
                    list.FullNamePeople = last.FullName;
                    list.NumberPhonePeople = last.NumberPhone;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data from file: {ex.Message}");
            }
        }


        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // достаем указатель на ресурс
                ListOfPeoples list = Resources["ListOfPeople"] as ListOfPeoples;

                // создаем человека
                People people = new People();

                // инициализируем поля
                people.FullName = list.FullNamePeople;
                people.Address = list.AddressPeople;
                people.NumberPhone = list.NumberPhonePeople;

                // добавляем в колекцию.
                list.Peoples.Add(people);

            }
            catch (Exception ex) { }
        }
    }

    public class ListOfPeoples : INotifyPropertyChanged
    {
        public ObservableCollection<People> Peoples { get; set; } = new ObservableCollection<People>();
        
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

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            // вызываем только те события, которые касаются определенного поля
            PropertyChanged?.Invoke(this, e);
        }
    }
    [Serializable]
    public class People : INotifyPropertyChanged
    {
        [DataMember]
        private string _FullName;
        [DataMember]
        private string _Address;
        [DataMember]
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
        public People()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            // вызываем только те события, которые касаются определенного поля
            PropertyChanged?.Invoke(this, e);
        }
    }

}
