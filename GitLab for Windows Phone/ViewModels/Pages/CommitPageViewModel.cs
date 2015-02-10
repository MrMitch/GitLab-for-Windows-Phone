using System.Collections.Generic;
using GitLab_for_Windows_Phone.Models;

namespace GitLab_for_Windows_Phone.ViewModels.Pages
{
    public class CommitPageViewModel : BindableBase
    {
        private Commit _commit;
        public Commit Commit
        {
            get { return _commit; }
            set { SetValue(ref _commit, value); }
        }

        private List<FileDiff> _diffs;
        public List<FileDiff> Diffs
        {
            get { return _diffs; }
            set { SetValue(ref _diffs, value); }
        }
    }
}
