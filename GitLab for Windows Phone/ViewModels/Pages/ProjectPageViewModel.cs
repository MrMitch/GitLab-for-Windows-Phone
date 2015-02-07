using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitLab_for_Windows_Phone.Models;

namespace GitLab_for_Windows_Phone.ViewModels.Pages
{
    public class ProjectPageViewModel : BindableBase
    {
        private Project _project;
        public Project Project
        {
            get { return _project; }
            set { SetValue(ref _project, value); }
        }

        public ObservableCollection<Commit> Commits { get; set; }

        public ProjectPageViewModel()
        {
            Commits = new ObservableCollection<Commit>();
        }
    }
}
