using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace GitLab_for_Windows_Phone.Api
{
    public static class GitLabClientFactory
    {
        private static string _serverAddress;
        public static string ServerAddress
        {
            get
            {
                if (String.IsNullOrWhiteSpace(_serverAddress))
                {
                    _serverAddress = ApplicationData.Current.RoamingSettings.Values["serverAddress"] as string;
                }
                return _serverAddress;
            }
        }

        private static string _token;
        public static string Token
        {
            get
            {
                if (String.IsNullOrWhiteSpace(_token))
                {
                    _token = ApplicationData.Current.RoamingSettings.Values["token"] as string;
                }
                return _token;
            }
        }

        public static GitLabApiClient GetInstance()
        {
            return new GitLabApiClient(ServerAddress, Token);
        }

    }
}
