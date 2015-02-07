using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using GitLab_for_Windows_Phone.Models;

namespace GitLab_for_Windows_Phone.ViewModels.Pages
{
    public class HomePageViewModel : BindableBase
    {
        public ObservableCollection<Project> Projects { get; set; }
        public ObservableCollection<Project> FavoriteProjects { get; set; }

        private List<GroupViewModel> _groups;
        public List<GroupViewModel> Groups
        {
            get { return _groups; }
            set { SetValue(ref _groups, value); }
        }

        public HomePageViewModel()
        {
            Projects = new ObservableCollection<Project>();
            FavoriteProjects = new ObservableCollection<Project>();
        }

        public virtual Task<IEnumerable<Project>> RetrieveProjects()
        {
            return Task.FromResult(Enumerable.Empty<Project>());
        }
    }
}
