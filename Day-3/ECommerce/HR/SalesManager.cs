using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    public class SalesManager:SalesEmployee
    {
        public double Target { get; set; }
        public double Incentive { get; set; }
        public SalesManager():base()
        {
            Target = 600000;
            Incentive = 50000;
        }

        public SalesManager(string fName, string lName,
            string loginName, string password, double bSalary,
            double hra, double da, double bonus,double target,double incentive) : base(fName, lName,
                loginName, password, bSalary, hra
            , da,bonus)
        {
            this.Target = target;
            this.Incentive = incentive;
        }

        public override double ComputePay()
        {
            double pay = 0;
            if(Target>700000)
            {
                pay = base.ComputePay() + Incentive;
            }
            else
            {
                pay = base.ComputePay();
            }
            return pay;
        }

        public override bool DoWork()
        {
            return base.DoWork();
        }
    }
}
