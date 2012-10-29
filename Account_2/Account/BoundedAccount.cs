using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Account
{
    class BoundedAccount : Account
    {
        public BoundedAccount(string Name, double startbalance = 0) :
            base(Name, startbalance)
        {
            if (startbalance < 0)
            {
                throw new Exception("Startbalance can not be below zero");
            }
        }
        public override void Withdraw(double val)
        {
            if (GetBalance() - val < 0)
            {
                throw new Exception("cant withdraw " + val + " from " + GetBalance());
            }
            base.Withdraw(val);
        }
    }
}
