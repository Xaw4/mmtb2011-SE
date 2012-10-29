//Hubert Scharfetter
//Andreas Wallinger

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Welcome to the new Account-Manager-3000 ----");

            Manager m = Manager.getInstance();

            m.addAccount(new Account("Fred", 50));
            m.dumpAccounts();
            m.addAccount(new Account("hons", 60));
            m.dumpAccounts();
            m.addAccount(new Account("Hubert"));
            m.dumpAccounts();

            Changeable ch = new Account("Chhh", 1000);

            LogObserver logger = new LogObserver();
            ch.registerObserver(logger);

            Account acc = ch as Account;
            acc.Deposit(100);

            acc.registerObserver(logger);
            acc.Withdraw(200);


            Console.ReadLine();
        }
    }
}
