﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfIdeaAdmin.ViewModel.Commands
{
    public class CustomerCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action _execute;

        //constructor
        public CustomerCommand(Action execute)
        {
            _execute = execute;
        }


        public bool CanExecute(object parameter)
        {
            //throw new NotImplementedException();
            return true;
        }

        public void Execute(object parameter)
        {
            //throw new NotImplementedException();
            _execute.Invoke();
        }
    }
}
