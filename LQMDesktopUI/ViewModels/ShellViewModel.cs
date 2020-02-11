using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace LQMDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private LoginViewModel _loginVM;

        public ShellViewModel()
        {
            LoginViewModel loginVM = new LoginViewModel();
            _loginVM = loginVM;
            ActivateItem(loginVM);
        }
    }
}
