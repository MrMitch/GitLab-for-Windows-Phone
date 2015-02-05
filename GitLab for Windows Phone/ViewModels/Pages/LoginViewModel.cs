using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitLab_for_Windows_Phone.Common;
using GitLab_for_Windows_Phone.Services;

namespace GitLab_for_Windows_Phone.ViewModels.Pages
{
    public class LoginViewModel
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
                            // todo
                            NavigationService.NavigateToRepositoryList();
                        },
                        () => !String.IsNullOrWhiteSpace(Login) && !String.IsNullOrWhiteSpace(Password)
                    );
                }
                return _loginCommand;
            }
        }
        
        
    }
}
