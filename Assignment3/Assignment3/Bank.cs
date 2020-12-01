using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Bank
    {
        double NetBalance = 650000;
        double transamount;

        public void deposit()
        {
            NetBalance = NetBalance + transamount;
            Console.WriteLine(NetBalance);
        }
        public void withdrawal()
        {
            NetBalance = NetBalance - transamount;
            Console.WriteLine(NetBalance);
        }   
        public Bank(double transamount)
        {
            this.transamount = transamount;
        }
        public double Netbalance
        {
            get; set;
        }
    }
    
}
