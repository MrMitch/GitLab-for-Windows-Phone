using System.Collections.ObjectModel;
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

        private Branch _selectedBranch;
        public Branch SelectedBranch
        {
            get { return _selectedBranch; }
            set { SetValue(ref _selectedBranch, value); }
        }

        public ObservableCollection<Commit> Commits { get; set; }

        public ObservableCollection<Branch> Branches { get; set; }

        public ObservableCollection<Issue> OpenedIssues { get; set; }

        public ObservableCollection<Issue> ClosedIssues { get; set; }

        public ProjectPageViewModel()
        {
            Commits = new ObservableCollection<Commit>();
            Branches = new ObservableCollection<Branch>();
            OpenedIssues = new ObservableCollection<Issue>();
            ClosedIssues = new ObservableCollection<Issue>();
        }
    }
}
