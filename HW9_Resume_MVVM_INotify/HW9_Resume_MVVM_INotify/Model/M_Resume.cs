using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace HW9_Resume_MVVM_INotify.Model
{
    public class M_Resume
    {
        public List<M_Contact> Contacts;

        public string SourceImage;
        public string FullName;
        public string Age;
        public string Post;
        public string Salary;

        public M_Resume() 
        { 
            Contacts = new List<M_Contact>();

            SourceImage = "ImageCat.jpg";
            FullName = "Сетевая Медея Николаевна";
            Age = "33 года";
            Post = "СММ-специалист";
            Salary = "70 000";
        }
    }
}
