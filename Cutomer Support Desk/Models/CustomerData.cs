using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cutomer_Support_Desk.Models
{
    public class CustomerData
    {
        public string Name { get; }
        public string Username { get; }
        public string Address { get; }
        public string Email { get; }
        public string Phone { get; }

        public CustomerData(string name, string userName, string address, string email, string phone)
        {
            Name = name;
            Username = userName;
            Address = address;
            Email = email;
            Phone = phone;
        }

    }
}
