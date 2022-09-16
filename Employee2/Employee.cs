using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee2
{
    internal class Employee
    {
        protected int id;
        private static int count = 0;
        protected string name;
        protected double bs, hra, da, pt, pf, total, netpaid;
        public Employee( string name, double bs,  double pt)

        {
            count++;
            id=count;
           
            this.name = name;
            this.bs = bs;
           
            this.pt = pt;
          
        }
        public static int DisplayCount()
        {

            return count;
        }
        public virtual void CalculateSalary()
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;
            total = bs + hra + da;
            netpaid = total - (pf + pt);
        }
        public override string ToString()
        {
            return $"Employee Id {id} Employee Name{name} Total salary{total} Netpaid {netpaid}";
        }
        public class Manager : Employee
        {
            private double ta;
          
              
                public Manager(string name, double bs, double pt, double ta) : base(name, bs, pt) 
                {
                    this.ta = ta;
                }
                public override void CalculateSalary()
                {
                    hra = bs * 0.40;
                    da = bs * 0.20;
                    pf = bs * 0.12;
                    total = bs + hra + da + ta;
                    netpaid = total - (pf + pt);
                }
                public override string ToString()
                {
                    return $"Manager Id {id} Manager name {name} , total salary {total} & Net paid {netpaid}";
                }
            

        }

    }
}
