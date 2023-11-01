﻿using System;
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
        public List<M_Skill> WorkSkill;
        public List<M_Skill> SocialSkill;
        public List<M_Language> Languages;
        public List<M_Job> Jobs;
        public string SourceImage;
        public string FullName;
        public string Age;
        public string Post;
        public string Salary;
        public M_Resume() 
        { 
            SourceImage = "ImageCat.jpg";

            Contacts = new List<M_Contact>();
            Languages = new List<M_Language>();
            WorkSkill = new List<M_Skill>();
            SocialSkill = new List<M_Skill>();
            Jobs = new List<M_Job>();
        }
    }
}
