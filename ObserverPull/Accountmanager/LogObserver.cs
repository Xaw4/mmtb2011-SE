//Hubert Scharfetter
//Andreas Wallinger

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class LogObserver : Observer
    {

        public LogObserver(Account acc)
        {

            this.acc = acc;
            this.oldBalance = this.acc.getBalance();
        }

        public void update()
        {

            Console.WriteLine("Account of " + acc.getName() + ":");
            Console.WriteLine("Old Balance: " + oldBalance);
            Console.WriteLine("New Balance: " + acc.getBalance());
            Console.WriteLine("Change: " + (acc.getBalance() - oldBalance));

            oldBalance = acc.getBalance();

        }

        private Account acc;
        private float oldBalance; 
    }

