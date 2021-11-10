using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cutomer_Support_Desk.ViewModels
{
    public class MainVM:BaseVM
    {
        public BaseVM CurrentVM { get; }
        public MainVM()
        {
            CurrentVM = new LoginVM();
        }
    }
}
