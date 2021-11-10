﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cutomer_Support_Desk.ViewModels
{
    public class DashboardVM : BaseVM
    {
        private string _username;

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        public ICommand SearchCommand { get; }
        public ICommand LogoutCommand { get; }
        public DashboardVM()
        {

        }
    }
}
