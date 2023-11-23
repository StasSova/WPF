using HW11_Gallery.View;
using HW11_Gallery.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace HW11_Gallery.Service
{
    using System;
    using System.Collections.Generic;
    using System.Security.Policy;
    using System.Windows;

    public class NavigationService
    {
        protected readonly Dictionary<Type, Type> _mappings;
        
        static NavigationService _instance;
        public static NavigationService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NavigationService();

                return _instance;
            }
        }

        private NavigationService()
        {
            _mappings = new Dictionary<Type, Type>();
            CreatePageViewModelMappings();
        }

        void CreatePageViewModelMappings()
        {
            // окна регистрации
            _mappings.Add(typeof(VM_MainWindow), typeof(MainWindow));
            // Главное окно приложения
            _mappings.Add(typeof(VM_Main), typeof(V_Main));
        }

        public void NavigateToPage<VM>() where VM : VM_Base
        {
            Type viewModelType = typeof(VM);
            if (_mappings.TryGetValue(viewModelType, out Type viewType))
            {
                // Создание экземпляра ViewModel и View
                VM viewModel = (VM)Activator.CreateInstance(viewModelType);
                FrameworkElement view = (FrameworkElement)Activator.CreateInstance(viewType);

                // Привязка ViewModel к View (может потребоваться настройка)
                view.DataContext = viewModel;
                (view as Window).Show();
                var prev = Application.Current.MainWindow;
                Application.Current.MainWindow = view as Window;
                prev.Close();
            }
            else
            {
                // Обработка ошибки, если маппинг отсутствует
                MessageBox.Show($"Mapping not found for ViewModel type: {viewModelType.Name}");
            }
        }


    }
}
