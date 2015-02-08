using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitLab_for_Windows_Phone.Models;

namespace GitLab_for_Windows_Phone.ViewModels.Pages
{
    public class IssuePageViewModel : BindableBase
    {
        private Issue _issue;
        public Issue Issue
        {
            get { return _issue; }
            set { SetValue(ref _issue, value); }
        }

        public ObservableCollection<Note> Comments { get; set; }
    }
}
