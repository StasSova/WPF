using HW11_Gallery.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_Gallery.ViewModel
{
    public class VM_Images: VM_Base
    {
        private M_Images model;
        public M_Images Model { get { return model; } }
        public VM_Images(M_Images model) 
        {
            this.model = model;
            
            // Находим индекс элемента по ключу
            int index = model.Ratings.FindIndex(x => x.Key == M_User.Instance.Login);
            if (index != -1)
            {
                // Изменяем значение элемента по индексу
                MyMark = model.Ratings[index].Value;
            }
            else MyMark = 0;
        }
        public string Author
        {
            get { return model.Author; }
            set
            {
                model.Author = value;
                OnPropertyChanged(nameof(Author));
            }
        }
        public string Name
        {
            get { return model.Name; }
            set
            {
                model.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Date
        {
            get { return model.Date; }
            set
            {
                model.Date = value;
                OnPropertyChanged(nameof(Date));
            }
        }
        public string PathToPhoto
        {
            get 
            {
                //return $"../../../Resources/Images/{Model.PathToPhoto}";
                string destinationPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"..", "..", "..", "Resources", "Images", Model.PathToPhoto);
                return destinationPath;
            }
            set
            {
                model.PathToPhoto = value;
                OnPropertyChanged(nameof(PathToPhoto));
            }
        }
        public string AvaregeRating
        {
            get 
            { 
               return (model.Ratings.Select(x => x.Value).Sum()/model.Ratings.Count).ToString("F2");
            }
        }
        public string NumberOfRatings 
        {
            get { return model.Ratings.Count.ToString(); }
        }

        private double myMark;
        public double MyMark
        {
            get
            {
                return myMark;
            }
            set
            {
                if (myMark == value) return;
                myMark = value;
                 //Находим индекс элемента по ключу
                int index = model.Ratings.FindIndex(x => x.Key == M_User.Instance.Login);

                if (index != -1)
                {
                    // Изменяем значение элемента по индексу
                    model.Ratings[index] = new SerializableKeyValuePair(M_User.Instance.Login, myMark);
                }
                else
                {
                    // Элемент не найден
                    model.Ratings.Add(new SerializableKeyValuePair(M_User.Instance.Login, myMark));
                }
                OnPropertyChanged(nameof(MyMark));
            }
        }
    }
}
