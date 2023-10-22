using HW6_Binding.ViewModel;
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
        VM_ListPeoples context;
        public MainWindow()
        {
            InitializeComponent();
            context = (VM_ListPeoples)DataContext;
        }

        // КОСТЫЛЬ
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            context.ListBox_SelectionChanged(sender, e);
        }
    }
}
