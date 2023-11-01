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
        public string SourceImage;
        public string FullName;
        public string Age;
        public string Post;
        public string Salary;

        public string Phone;
        public string Email;

        // ЗНАНИЕ ЯЗЫКОВ РЕАЛИЗОВАТЬ ПОЗЖЕ

        public string ProffSkill;
        public string CommSkill;

        public M_Resume() 
        { 
            SourceImage = "ImageCat.jpg";
            FullName = "Сетевая Медея Николаевна";
            Age = "33 года";
            Post = "СММ-специалист";
            Salary = "70 000";


            Phone = "+3806666543";
            Email = "Example@gmail.com";

            ProffSkill = "* Instagramm, FB, VK, YouTube\n" +
                         "* Photoshop, Illustratir, Lumyer, Movavi";

            CommSkill = "* Коммуникабельность\n" +
                "* Ответственность\n" +
                "* Пунктуальность";
        }
    }
}
