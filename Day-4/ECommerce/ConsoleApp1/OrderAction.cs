using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class OrderAction
    {
        public bool Approve() { return false; }
        public bool IsApproved() { return false; }
        public bool Reject() { return true; }
        public bool Cancel() { return false; }
       
    }
}
