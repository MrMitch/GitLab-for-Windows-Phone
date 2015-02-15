using System.Collections.Generic;
using GitLab_for_Windows_Phone.Models;

namespace GitLab_for_Windows_Phone.ViewModels
{
    public class TreeElementViewModel
    {
        public TreeElement TreeElement { get; set; }

        public List<TreeElementViewModel> Children { get; set; }
    }
}
