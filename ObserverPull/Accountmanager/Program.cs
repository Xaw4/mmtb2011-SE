//Hubert Scharfetter
//Andreas Wallinger


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
    {
        static void Main(string[] args)
        {


            Account acc = new Account("Hubert", 500);
            Console.Out.WriteLine(acc);

            Observer o = new LogObserver(acc);

            acc.registerObserver(o); 

            acc.deposit(300);

            acc.withdraw(178);

            acc.withdraw(1000);

            acc.deposit(700);

            acc.removeObserver(o);

            acc.deposit(1000); 

            Console.In.ReadLine();

  
        }
    }

