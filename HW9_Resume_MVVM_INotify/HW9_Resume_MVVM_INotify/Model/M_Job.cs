using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_Resume_MVVM_INotify.Model
{
    [Serializable]
    public class M_Job
    {
        public string StartDate;
        public string EndDate;
        public string Company;
        public string Post;
        public string Description;
        public M_Job() 
        {
            StartDate = "StartDate";
            EndDate = "EndDate";
            Company = "Company";
            Post = "Post";
            Description = "Description";
        }
    }
}
