//Hubert Scharfetter
//Andreas Wallinger

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Account
{
    class Account : Changeable
    {
        private string name;
        private double money;

        private List<ChangeObserver> observers = new List<ChangeObserver>();

        public Account(string Name, double startbalance = 0)
        {
            name = Name;
            money = startbalance;
        }

        public double GetBalance()
        {
            return money;
        }

        public virtual void Deposit(double val)
        {
            money += val;
            ChangedEvent e = new ChangedEvent(val, money);
            notifyObservers(e);

        }

        public virtual void Withdraw(double val)
        {
            money -= val;
            ChangedEvent e = new ChangedEvent(-val, money);
            notifyObservers(e);
        }

        public override string ToString()
        {
            return "Name: " + name + ", Money: " + money;
        }


        // Observer Methods
        public void registerObserver(ChangeObserver observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(ChangeObserver observer)
        {
            observers.Remove(observer);    
        }

        public void notifyObservers(ChangedEvent e)
        {
            foreach (ChangeObserver observer in observers)
            {
                observer.update(e);
            }
        }
    }
}
