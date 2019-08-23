using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VundacTemplateApp.ViewModels
{
    public class MainPageVM : ViewModelBase
    {
        public MainPageVM(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }
    }
}
