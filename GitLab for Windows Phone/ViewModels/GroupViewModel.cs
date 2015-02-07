using System.Collections.Generic;
using GitLab_for_Windows_Phone.Models;

namespace GitLab_for_Windows_Phone.ViewModels
{
    public class GroupViewModel
    {
        public List<Project> Projects { get; set; }

        public Namespace Namespace { get; set; }
    }
}
