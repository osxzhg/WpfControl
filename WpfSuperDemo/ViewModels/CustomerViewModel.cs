using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfSuperDemo.Commands;
using WpfSuperDemo.Models;

namespace WpfSuperDemo.ViewModels
{
    internal class CustomerViewModel
    {
        public CustomerViewModel()
        {
            _Customer = new Customer("David");
            UpdateCommand = new CustomerUpdateCommand(this);
        }
        public bool CanUpdate
        {
            get { 
                if (Customer == null)
                {
                    return false;
                }
                return !String.IsNullOrWhiteSpace(Customer.Name);
            }
        }

        private Customer _Customer;

        public Customer Customer
        {
            get
            {
                return _Customer;
            }
        }
        public ICommand UpdateCommand
        {
            get;
            private set;
        }
        public void SaveChanges()
        {
            Debug.Assert(false, String.Format("{0} was update", Customer.Name));
        }
    }
}
