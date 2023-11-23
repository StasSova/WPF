using HW11_Gallery.Service;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.IO;


namespace HW11_Gallery.ViewModel
{
    public class VM_Add_Picture: VM_Base
    {

        private Window? _view;
        public Window? View
        {
            get { return _view; }
            set
            {
                if (_view != value)
                {
                    _view = value;
                    OnPropertyChanged(nameof(View));
                }
            }
        }
        public string path;
        private string _name;
        public string NamePicture
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value) 
                {
                    _name = value;
                    OnPropertyChanged(nameof(NamePicture));
                }
            }
        }

        public string selectedImagePath;
        // START IMAGES
        private DelegateCommand? _addImages;
        private void AddImages()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Выберите изображение",
                    Filter = "Изображения (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png",
                    Multiselect = false
                };

                if (openFileDialog.ShowDialog() == true)
                {
                    // openFileDialog.FileName содержит путь к выбранному файлу
                    selectedImagePath = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }
        }
        private bool CanAddImages()
        {
            return true;
        }
        public ICommand AddImagesCommand
        {
            get
            {
                if (_addImages == null)
                    _addImages = new DelegateCommand(ex => AddImages(), ce => CanAddImages());
                return _addImages;
            }
        }

        private void CopyImageToProjectFolder(string sourceImagePath)
        {
            try
            {
                // Получаем имя файла из пути
                path = Path.GetFileName(sourceImagePath);

                // Создаем новый путь для копии в папке с проектом
                string projectPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", ".."));
                string destinationPath = Path.Combine(projectPath, "Resources", "Images", path);
                selectedImagePath = destinationPath;
                // Копируем файл
                File.Copy(sourceImagePath, destinationPath, false);
            }
            catch (Exception ex)
            {
                // Обработка ошибок при копировании
                MessageBox.Show($"Ошибка при копировании изображения: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private DelegateCommand? _save;
        private void Save()
        {
            if (selectedImagePath == null || string.IsNullOrWhiteSpace(NamePicture))
            {
                MessageBox.Show("Error. Can't add image", "Error", MessageBoxButton.OK);
            }
            else
            {
                // Копирование изображения в папку с проектом (предположим, что проект находится в текущей директории)
                CopyImageToProjectFolder(selectedImagePath);
                // Закрыть окно с результатом true
                View.DialogResult = true;
                View.Close();
            }
        }
        private bool CanSave()
        {
            return true;
        }
        public ICommand SaveCommand
        {
            get
            {
                if (_save == null)
                    _save = new DelegateCommand(ex => Save(), ce => CanSave());
                return _save;
            }
        }



        private DelegateCommand? _exit;
        private void Exit()
        {
            View.DialogResult = false;
            View.Close();
        }
        private bool CanExit()
        {
            return true;
        }
        public ICommand ExitCommand
        {
            get
            {
                if (_exit == null)
                    _exit = new DelegateCommand(ex => Exit(), ce => CanExit());
                return _exit;
            }
        }
    }
}
