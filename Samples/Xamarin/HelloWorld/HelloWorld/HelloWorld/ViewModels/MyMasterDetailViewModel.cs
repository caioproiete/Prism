﻿using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Navigation;

namespace HelloWorld.ViewModels
{
    public class MyMasterDetailViewModel : BindableBase
    {
        INavigationService _navigationService;

        public DelegateCommand<string> NavigateCommand { get; set; }
        public MyMasterDetailViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string name)
        {
            _navigationService.Navigate(name);
        }
    }
}
