using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Cutomer_Support_Desk.Models;

namespace Cutomer_Support_Desk.ViewModels
{
    internal class CustomerInfoVM:BaseVM
    {
        private readonly CustomerData _customerData=new CustomerData("John Doe","johndoe","London, United Kingdom","johndoe@email.co.uk","07123456789");
        public string Name => _customerData.Name;
        public string Username => _customerData.Username;
        public string Address => _customerData.Address;
        public string Email => _customerData.Email;
        public string Phone => _customerData.Phone;
        public ICommand BackCommand { get;}
        public CustomerInfoVM()
        {

        }
    }
}
