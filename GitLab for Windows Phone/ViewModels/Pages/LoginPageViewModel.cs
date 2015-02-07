using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;
using GitLab_for_Windows_Phone.Common;
using GitLab_for_Windows_Phone.Services;

namespace GitLab_for_Windows_Phone.ViewModels.Pages
{
    public class LoginPageViewModel
    {
        private string _login;
        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                LoginCommand.RaiseCanExecuteChanged();
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                LoginCommand.RaiseCanExecuteChanged();
            }
        }

        private string _serverAddress;
        public string ServerAddress
        {
            get { return _serverAddress; }
            set
            {
                _serverAddress = value;
                LoginCommand.RaiseCanExecuteChanged();
            }
        }

        private RelayCommand<object> _loginCommand;
        public RelayCommand<object> LoginCommand
        {
            get
            {
                if (_loginCommand == null)
                {
                    return _loginCommand = new RelayCommand<object>(
                        (_) =>
                        {
                            var client = new HttpClient();
                            //client.PostAsync(new Uri(ServerAddress + "/api/v3/sesson"), new HttpStringContent(""));
                            NavigationService.NavigateToHome();
                        },
                        () => !String.IsNullOrWhiteSpace(Login) && !String.IsNullOrWhiteSpace(Password) && !String.IsNullOrWhiteSpace(ServerAddress)
                    );
                }
                return _loginCommand;
            }
        }
        
        
    }
}
