using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfSuperDemo.ViewModels;

namespace WpfSuperDemo.Commands
{
    internal class CustomerUpdateCommand : ICommand
    {
        public CustomerUpdateCommand(CustomerViewModel viewModel)
        {
            _ViewModel = viewModel;
        }
        private CustomerViewModel _ViewModel;
        public event System.EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _ViewModel.CanUpdate;
        }
        public void Execute(object parameter)
        {
            _ViewModel.SaveChanges();
        }
    }
}
