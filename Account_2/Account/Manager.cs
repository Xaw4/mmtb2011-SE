//Hubert Scharfetter
//Andreas Wallinger

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Account
{
    class Manager
    {
        private List<Account> accounts = new List<Account>();

        private static Manager instance = null;

        private Manager() { }

        public static Manager getInstance()
        {
            if (instance == null)
            {
                instance = new Manager();
            }
            return instance;
        }

        public void addAccount(Account acc){
            accounts.Add(acc);
        }

        public List<Account> getAccounts()
        {
            return accounts;
        }

        public void dumpAccounts()
        {
            Console.WriteLine("Accounts:");
            foreach (Account a in accounts)
            {
                Console.WriteLine(a.ToString());
            }
        }
    }
}
