using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;
using System.Windows.Input;
using WpfApp1.Commands;

namespace WpfApp1.ViewModels
{
    class CustomerViewModel
    {
        public CustomerViewModel(String name)
        {
            customer = new Customer(name);
            UpdateCommand = new CustomerUpdateCommand(this);
        }

        public bool CanUpdate
        {
            get
            {
                if(Customer == null)
                {
                    return false;
                }
                return !String.IsNullOrWhiteSpace(Customer.Name);
            }
        }


        private Customer customer;

        public Customer Customer
        {
            get
            {
                return customer;
            }
        }

        public void SaveChanges()
        {
            Debug.Assert(false, "A change was made to the customer");
        }

        public ICommand UpdateCommand
        {
            get;
            private set; 
        }
    }
}
