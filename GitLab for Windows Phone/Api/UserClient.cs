using GitLab_for_Windows_Phone.Models;
using GitLab_for_Windows_Phone.Utils;

namespace GitLab_for_Windows_Phone.Api
{
    public class UserClient
    {
        public GitLabApiClient ApiClient { get; set; }
        public UserClient()
        {
            ApiClient = new GitLabApiClient(SettingsHelper.Local["server"].ToString(), SettingsHelper.Local["token"].ToString());
        }

        public Session
    }
}
