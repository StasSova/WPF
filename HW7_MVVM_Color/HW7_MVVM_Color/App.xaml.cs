using HW7_MVVM_Color.View;
using HW7_MVVM_Color.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HW7_MVVM_Color
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            V_Main view = new V_Main();
            //VM_Main viewmodel = new VM_Main();
            //view.DataContext = viewmodel;
            view.Show();
        }
    }
}
