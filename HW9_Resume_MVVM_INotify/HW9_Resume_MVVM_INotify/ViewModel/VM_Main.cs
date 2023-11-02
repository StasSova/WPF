using HW9_Resume_MVVM_INotify.Model;
using HW9_Resume_MVVM_INotify.Service;
using HW9_Resume_MVVM_INotify.ViewModel.TEMPLATE;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HW9_Resume_MVVM_INotify.ViewModel
{
    public class VM_Main:VM_Base
    {
        public ObservableCollection<VM_Resume> Resumes { get; set; }
        private int sel;
        public int SelectedResume 
        { 
            get { return sel; }
            set
            {
                sel = value;
                if (sel > -1)
                Current = Resumes[sel];
                OnPropertyChanged(nameof(SelectedResume));
            }
        }

        private VM_Resume _resume;
        public VM_Resume Current
        {
            get { return _resume; }
            set
            {
                _resume = value;
                OnPropertyChanged(nameof(Current));
            }
        }
        public VM_Main()
        {
            Current = new VM_Resume();
            Resumes = new ObservableCollection<VM_Resume>();
            LoadPeople();
            if (Resumes.Count == 0)
                Resumes.Add(new VM_Resume());
        }

        
        
        // SAVE RESUMES
        private DelegateCommand? _savePeoples;
        private void SavePeople()
        {
            List<M_Resume> modelContacts = Resumes.Select(vm => new M_Resume
            {
                SourceImage = vm.ImageSource,
                FullName = vm.FullName,
                Age = vm.Age,
                Post = vm.Post,
                Salary = vm.Salary,
                
                Contacts = vm.Contacts.Select(c => c.Contact).ToList(),
                    //c => new M_Contact
                    //{
                    //    Info = c.Info
                    //}).ToList(),

                WorkSkill = vm.WorkSkills.Select(c => c.Skill).ToList(),
                    //w=>new M_Skill
                    //{
                    //    Skill = w.SkillName
                    //}).ToList(),

                SocialSkill = vm.SocialSkills.Select(c => c.Skill).ToList(),
                    //w => new M_Skill
                    //{
                    //    Skill = w.SkillName
                    //}).ToList(),
                
                Languages = vm.Languages.Select(l => l.Lang).ToList(),
                    //l => new M_Language
                    //{
                    //    Language = l.Language,
                    //    Level = l.Level
                    //}).ToList(),

                Jobs = vm.Jobs.Select(j => j.Model).ToList(),
                    //j => new M_Job
                    //{
                    //    Company = j.Company,
                    //    StartDate = j.StartDate,
                    //    EndDate = j.EndDate,
                    //    Post = j.Post,
                    //    Description = j.Description
                    //}).ToList(),

            }).ToList();
            ManipulationData.Instance.Save(modelContacts);
        }
        private bool CanSavePeople()
        {
            return Resumes.Count > 0;
        }
        public ICommand SavePeopleCommand
        {
            get
            {
                if (_savePeoples == null)
                    _savePeoples = new DelegateCommand(ex => SavePeople(), ce => CanSavePeople());
                return _savePeoples;
            }
        }

        //LOAD COLLECTION
        private void LoadPeople()
        {
            List<M_Resume> modelContacts = ManipulationData.Instance.GetCollection();
            if (modelContacts == null) return;
            if (modelContacts.Count == 0) return;
            Resumes.Clear();
            foreach (M_Resume modelContact in modelContacts)
            {
                Resumes.Add(new VM_Resume(modelContact));
            }
        }


        private DelegateCommand? _addResume;
        private void AddResume()
        {
            Resumes.Add(new VM_Resume());
            SelectedResume = Resumes.Count - 1;
        }
        private bool CanAddResume() { return true; }
        public ICommand AddResumeCommand
        {
            get
            {
                if (_addResume==null)
                    _addResume = new DelegateCommand(e => AddResume(), ce => CanAddResume());
                return _addResume;
            }
        }


        private DelegateCommand? _removeResume;
        private void RemoveResume()
        {
            Resumes.RemoveAt(SelectedResume);
            if (Resumes.Count > 0) SelectedResume = 0;
        }
        private bool CanRemoveResume() { return SelectedResume > -1; }
        public ICommand RemoveCommand
        {
            get
            {
                if (_removeResume == null)
                    _removeResume = new DelegateCommand(e => RemoveResume(), ce => CanRemoveResume());
                return _removeResume;
            }
        }



    }
}
