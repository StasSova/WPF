using HW11_Gallery.Model;
using HW11_Gallery.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HW11_Gallery.ViewModel
{
    public class VM_Main: VM_Base
    {
        ObservableCollection<VM_Images> Images { get; set; } = new ObservableCollection<VM_Images> { };
        private VM_Images _images;
        public VM_Images CurrentImage
        {
            get
            {
                return _images;
            }
            set
            {
                if (_images != value) 
                {
                    _images = value;
                    OnPropertyChanged(nameof(CurrentImage));
                }
            }
        }

        private int currentPosition = 0;
        public int CurrentPosition
        {
            get { return currentPosition;}
            set
            {
                currentPosition = value;
                CurrentImage = Images[CurrentPosition];
                OnPropertyChanged(nameof(CurrentPosition));
            }
        }

        private int maximumImages;
        public int MaximumImages
        {
            get { return maximumImages; }
            set
            {
                maximumImages = value;
                OnPropertyChanged(nameof(MaximumImages));
            }
        }

        // NEXT IMAGES
        private DelegateCommand? _nextImages;
        private void NextImages()
        {
            // Смещаем ползунок на 1 ячейку вперед
            CurrentPosition += 1;
        }
        private bool CanNextImages()
        {
            return CurrentPosition != MaximumImages;
        }
        public ICommand NextImagesCommand
        {
            get
            {
                if (_nextImages == null)
                    _nextImages = new DelegateCommand(ex => NextImages(), ce => CanNextImages());
                return _nextImages;
            }
        }
        
        // PREVIOUS IMAGES
        private DelegateCommand? _prevImages;
        private void PrevImages()
        {
            // Смещаем ползунок на 1 ячейку назад
            CurrentPosition -= 1;
        }
        private bool CanPrevImages()
        {
            return CurrentPosition > 0;
        }
        public ICommand PrevImagesCommand
        {
            get
            {
                if (_prevImages == null)
                    _prevImages = new DelegateCommand(ex => PrevImages(), ce => CanPrevImages());
                return _prevImages;
            }
        }

        // START IMAGES
        private DelegateCommand? _startImages;
        private void StartImages()
        {
            // Смещаем ползунок на 1 ячейку назад
            CurrentPosition = 0;
        }
        private bool CanStartImages()
        {
            return CurrentPosition != 0;
        }
        public ICommand StartImagesCommand
        {
            get
            {
                if (_startImages == null)
                    _startImages = new DelegateCommand(ex => StartImages(), ce => CanStartImages());
                return _startImages;
            }
        }

        // START IMAGES
        private DelegateCommand? _endImages;
        private void EndImages()
        {
            // Смещаем ползунок на 1 ячейку назад
            CurrentPosition = MaximumImages;
        }
        private bool CanEndImages()
        {
            return CurrentPosition != maximumImages;
        }
        public ICommand EndImagesCommand
        {
            get
            {
                if (_endImages == null)
                    _endImages = new DelegateCommand(ex => EndImages(), ce => CanEndImages());
                return _endImages;
            }
        }


        // ADD IMAGES
        private DelegateCommand? _addImages;
        private void AddImages()
        {
            VM_Add_Picture addPictureViewModel = new VM_Add_Picture();

            // Создание и отображение модального окна
            View.V_Add_Image addPictureWindow = new ()
            {
                DataContext = addPictureViewModel
            };
            addPictureViewModel.View = addPictureWindow;

            bool? result = addPictureWindow.ShowDialog();

            // После закрытия окна можно получить данные из ViewModel
            if (result == true)
            {
                string namePicture = addPictureViewModel.NamePicture;
                string path = addPictureViewModel.path;

                DateTime currentDateTime = DateTime.Now;
                string formattedDateTime = currentDateTime.ToString("dd.MM.yyyy HH:mm");
                M_Images model = new M_Images()
                {
                    Author = $"{M_User.Instance.Name} {M_User.Instance.Surname}",
                    Name = namePicture,
                    Date = formattedDateTime,
                    PathToPhoto = path,
                    Ratings = new List<SerializableKeyValuePair> { new SerializableKeyValuePair(M_User.Instance.Login, 5) }
                };
                Images.Add(new VM_Images(model));
                MaximumImages++;
                if (Images.Count == 1)
                    CurrentPosition = 0;
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


        private DelegateCommand? _saveImages;
        private void SaveImages()
        {
            try
            {
                if (Images.Count == 0) throw new Exception("Image list is empty");
                // достаем список моделей, всех картинок
                List<M_Images> list = Images.Select(x => x.Model).ToList();
                ImageService.SerializeToXml(list);
                MessageBox.Show("Images save", "Success", MessageBoxButton.OK);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }
        }
        private bool CanSaveImages()
        {
            return true;
        }
        public ICommand SaveImagesCommand
        {
            get
            {
                if (_saveImages == null)
                    _saveImages = new DelegateCommand(ex => SaveImages(), ce => CanSaveImages());
                return _saveImages;
            }
        }

        public VM_Main()
        {
            try
            {
                List<M_Images> images = ImageService.DeserializeFromXml();
                foreach (M_Images image in images) 
                {
                    Images.Add(new VM_Images(image));
                }
                if (Images.Count > 0)
                {
                    //Images[0].PathToPhoto = "../../../Resources/Images/a.jpg";
                    CurrentPosition = 0;
                }
                maximumImages = images.Count - 1;
            }
            catch 
            {
                
            }
        }

    }
}
