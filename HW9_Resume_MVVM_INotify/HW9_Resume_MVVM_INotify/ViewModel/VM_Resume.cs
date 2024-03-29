﻿using HW9_Resume_MVVM_INotify.Model;
using HW9_Resume_MVVM_INotify.Service;
using HW9_Resume_MVVM_INotify.ViewModel.TEMPLATE;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace HW9_Resume_MVVM_INotify.ViewModel
{
    public class VM_Resume : VM_Base
    {
        private M_Resume model;
        public ObservableCollection<VM_Contact> Contacts { get; set; }
        public ObservableCollection<VM_Language> Languages { get; set; }
        public ObservableCollection<VM_Skill> WorkSkills { get; set; }
        public ObservableCollection<VM_Skill> SocialSkills { get; set; }
        public ObservableCollection<VM_Job> Jobs { get; set; }


        public string ImageSource
        {
            get { return model.SourceImage; }
            set
            {
                model.SourceImage = value;
                OnPropertyChanged(nameof(ImageSource));
            }
        }
        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set
            {
                _fullName = value;
                OnPropertyChanged(nameof(FullName));
            }
        }
        private string _age;
        public string Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }
        private string _post;
        public string Post
        {
            get { return _post; }
            set
            {
                _post = value;
                OnPropertyChanged(nameof(Post));
            }
        }
        public string _salary;
        public string Salary
        {
            get { return _salary; }
            set
            {
                _salary = value;
                OnPropertyChanged(nameof(Salary));
            }
        }
        public VM_Resume(M_Resume resume)
        {
            if (resume == null) return;
            this.model = resume;
            Load();
        }
        public VM_Resume()
        {
            model = new M_Resume();
            Load();
        }
        public override string ToString()
        {
            return $"{FullName}, {Age}, {Post}";
        }




        // CONTACTS

        // REMOVE CONTACT
        public int Index_selectedContact { get; set; }
        public ICommand RemoveContactCommand
        {
            get
            {
                if (_removeContact == null) _removeContact = new DelegateCommand(exec => RemoveContact(), can => CanRemoveContact());
                return _removeContact;
            }
        }
        private DelegateCommand _removeContact;
        private bool CanRemoveContact()
        {
            return Index_selectedContact != -1;
        }
        private void RemoveContact()
        {
            Contacts.RemoveAt(Index_selectedContact);
        }

        // ADD CONTACT
        public ICommand AddContactCommand
        {
            get
            {
                if (_addContact == null) _addContact = new DelegateCommand(exec => AddContact(), can => CanAddContact());
                return _addContact;
            }
        }
        private DelegateCommand _addContact;
        private bool CanAddContact()
        {
            return true;
        }
        private void AddContact()
        {
            Contacts.Add(new VM_Contact());
        }




        // LANGUAGES
        // REMOVE LANG
        public int Index_selectedLanguage { get; set; }
        public ICommand RemoveLangCommand
        {
            get
            {
                if (_removeLang == null) _removeLang = new DelegateCommand(exec => RemoveLang(), can => CanRemoveLang());
                return _removeLang;
            }
        }
        private DelegateCommand _removeLang;
        private bool CanRemoveLang()
        {
            return Index_selectedLanguage != -1;
        }
        private void RemoveLang()
        {
            Languages.RemoveAt(Index_selectedLanguage);
        }

        // ADD LANG
        public ICommand AddLangCommand
        {
            get
            {
                if (_addlang == null) _addlang = new DelegateCommand(exec => AddLang(), can => CanAddLang());
                return _addlang;
            }
        }
        private DelegateCommand _addlang;
        private bool CanAddLang()
        {
            return true;
        }
        private void AddLang()
        {
            Languages.Add(new VM_Language());
        }
        

        // WORK SKILL
        // REMOVE WORK SKILL
        public int Index_selectedWorkSkill { get; set; }
        public ICommand RemoveWorkSkillCommand
        {
            get
            {
                if (_removeWorkSkill == null) _removeWorkSkill = new DelegateCommand(exec => RemoveWorkSkill(), can => CanRemoveWorkSkill());
                return _removeWorkSkill;
            }
        }
        private DelegateCommand _removeWorkSkill;
        private bool CanRemoveWorkSkill()
        {
            return Index_selectedWorkSkill != -1;
        }
        private void RemoveWorkSkill()
        {
            WorkSkills.RemoveAt(Index_selectedWorkSkill);
        }
        // ADD WORK SKILL
        public ICommand AddWorkSkillCommand
        {
            get
            {
                if (_addWorkSkill == null) _addWorkSkill = new DelegateCommand(exec => AddWorkSkill(), can => CanAddWorkSkill());
                return _addWorkSkill;
            }
        }
        private DelegateCommand _addWorkSkill;
        private bool CanAddWorkSkill()
        {
            return true;
        }
        private void AddWorkSkill()
        {
            WorkSkills.Add(new VM_Skill());
        }

        
        
        // SOCIAL SKILL
        // REMOVE SOCIAL SKILL
        public int Index_selectedSocialSkill { get; set; }
        public ICommand RemoveSocialSkillCommand
        {
            get
            {
                if (_removeSocialSkill == null) _removeSocialSkill = new DelegateCommand(exec => RemoveSocialSkill(), can => CanRemoveSocialSkill());
                return _removeSocialSkill;
            }
        }
        private DelegateCommand _removeSocialSkill;
        private bool CanRemoveSocialSkill()
        {
            return Index_selectedSocialSkill != -1;
        }
        private void RemoveSocialSkill()
        {
            SocialSkills.RemoveAt(Index_selectedSocialSkill);
        }
        // ADD SOCIAL SKILL
        public ICommand AddSocialSkillCommand
        {
            get
            {
                if (_addSocialSkill == null) _addSocialSkill = new DelegateCommand(exec => AddSocialSkill(), can => CanAddSocialSkill());
                return _addSocialSkill;
            }
        }
        private DelegateCommand _addSocialSkill;
        private bool CanAddSocialSkill()
        {
            return true;
        }
        private void AddSocialSkill()
        {
            SocialSkills.Add(new VM_Skill());
        }
        
       

        // JOB
        // REMOVE JOB
        public int Index_selectedJob { get; set; }
        public ICommand RemoveJobCommand
        {
            get
            {
                if (_removeJobSkill == null) _removeJobSkill = new DelegateCommand(exec => RemoveJob(), can => CanRemoveJob());
                return _removeJobSkill;
            }
        }
        private DelegateCommand _removeJobSkill;
        private bool CanRemoveJob()
        {
            return Index_selectedJob != -1;
        }
        private void RemoveJob()
        {
            Jobs.RemoveAt(Index_selectedJob);
        }
        // ADD JOB
        public ICommand AddJobCommand
        {
            get
            {
                if (_addJob == null) _addJob = new DelegateCommand(exec => AddJob(), can => CanAddJob());
                return _addJob;
            }
        }
        private DelegateCommand _addJob;
        private bool CanAddJob()
        {
            return true;
        }
        private void AddJob()
        {
            Jobs.Add(new VM_Job());
        }



        // SAVE
        public ICommand SaveCommand
        {
            get
            {
                if (_save == null) _save = new DelegateCommand(exec => Save(), can => CanSave());
                return _save;
            }
        }
        private DelegateCommand _save;
        private bool CanSave()
        {
            return true;
        }
        private void Save()
        {
            model.FullName = FullName;
            model.Age = Age;
            model.Post = Post;
            model.Salary = Salary;

            if (model.Jobs == null) model.Jobs = new List<M_Job>();
            model.Jobs.Clear();
            foreach (VM_Job job in Jobs) 
            {
                model.Jobs.Add(job.Model);
            }

            if (model.Contacts == null) model.Contacts = new List<M_Contact>();
            model.Contacts.Clear();
            foreach (VM_Contact cont in Contacts)
            {
                model.Contacts.Add(cont.Contact);
            }


            if (model.SocialSkill == null) model.SocialSkill = new List<M_Skill>();
            model.SocialSkill.Clear();
            foreach (var cont in SocialSkills)
            {
                model.SocialSkill.Add(cont.Skill);
            }

            if (model.WorkSkill == null) model.WorkSkill = new List<M_Skill>();
            model.WorkSkill.Clear();
            foreach (var sk in WorkSkills)
            {
                model.WorkSkill.Add(sk.Skill);
            }

            if (model.Languages == null) model.Languages = new List<M_Language>();
            model.Languages.Clear();
            foreach (var ln in Languages)
            {
                model.Languages.Add(ln.Lang);
            }

        }


        // LOAD
        public ICommand LoadCommand
        {
            get
            {
                if (_load == null) _load = new DelegateCommand(exec => Load(), can => CanLoad());
                return _load;
            }
        }
        private DelegateCommand _load;
        private bool CanLoad()
        {
            return true;
        }
        private void Load()
        {
            FullName = model.FullName;
            Age = model.Age;
            Post = model.Post;
            Salary = model.Salary;

            // Очищаем коллекции, чтобы избежать дублирования данных при повторной загрузке
            if (Jobs == null) Jobs = new ObservableCollection<VM_Job> ();
            Jobs.Clear();
            if (Contacts == null) Contacts = new ObservableCollection<VM_Contact> ();
            Contacts.Clear();
            if (SocialSkills == null) SocialSkills = new ObservableCollection<VM_Skill> ();
            SocialSkills.Clear();
            if (WorkSkills == null) WorkSkills = new ObservableCollection<VM_Skill> () ;
            WorkSkills.Clear();
            if (Languages == null) Languages = new ObservableCollection<VM_Language> ();
            Languages.Clear();

            // Загрузка данных из модели в коллекции ViewModel
            foreach (var jobModel in model.Jobs)
            {
                VM_Job jobViewModel = new VM_Job();
                jobViewModel.Model = jobModel;
                Jobs.Add(jobViewModel);
            }

            foreach (var contactModel in model.Contacts)
            {
                VM_Contact contactViewModel = new VM_Contact();
                contactViewModel.Contact = contactModel;
                Contacts.Add(contactViewModel);
            }

            foreach (var socialSkillModel in model.SocialSkill)
            {
                VM_Skill skillViewModel = new VM_Skill();
                skillViewModel.Skill = socialSkillModel;
                SocialSkills.Add(skillViewModel);
            }

            foreach (var workSkillModel in model.WorkSkill)
            {
                VM_Skill skillViewModel = new VM_Skill();
                skillViewModel.Skill = workSkillModel;
                WorkSkills.Add(skillViewModel);
            }

            foreach (var languageModel in model.Languages)
            {
                VM_Language languageViewModel = new VM_Language();
                languageViewModel.Lang = languageModel;
                Languages.Add(languageViewModel);
            }
        }

    }
}
