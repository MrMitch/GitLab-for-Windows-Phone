using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitLab_for_Windows_Phone.Common;

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
                GetTokenCommand.RaiseCanExecuteChanged();
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                GetTokenCommand.RaiseCanExecuteChanged();
            }
        }

        private RelayCommand<object> _getTokenCommand;
        public RelayCommand<object> GetTokenCommand
        {
            get
            {
                if (_getTokenCommand == null)
                {
                    return _getTokenCommand = new RelayCommand<object>(
                        (_) => {},
                        () => !String.IsNullOrWhiteSpace(Login) && !String.IsNullOrWhiteSpace(Password)
                    );
                }
                return _getTokenCommand;
            }
        }
        
        
    }
}
