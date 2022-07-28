using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipRolesMgmt;
namespace HR
{
    public abstract class Employee: User
    {
        public Employee()
        {

        }
        public Employee(string fName,string lName,string loginName,
            string password,double bSalary,double hra,double da)
            :base(fName,lName,loginName,password)    
        {
            this.BasicSalary = bSalary;
            this.HRA = hra;
            this.DA = da;

        }
        public double BasicSalary { get; set; }

        public double HRA { get; set; }
        public double DA { get; set; }

        public virtual double ComputePay()
        {
            double pay = 0;
            pay = BasicSalary + HRA + DA * 30;
            return pay;

        }
        public abstract bool DoWork();
    }
}
