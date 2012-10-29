//Hubert Scharfetter
//Andreas Wallinger

using System;
using System.Collections.Generic;

public class Account : Subject
{
	public Account(string n, float m)
	{

        name = n;
        money = m;

	}

    public void deposit(float amount)
    {

        money += amount;
        notifyObserver();
    
    }

    public virtual void withdraw(float amount) 
    {

        money -= amount;
        notifyObserver();
    
    }
   
    public float getBalance() 
    { 
       
        return money; 
    
    }

    public string getName()
    {

        return name;

    }

    public override string ToString()
    {

        string account = name;
        account += ", ";
        account += money;
        account += " euro";

        return account;

    }

    public void registerObserver(Observer o)
    {
        observers.Add(o); 
    }

    public bool removeObserver(Observer o)
    {
       return observers.Remove(o);
    }

    public void notifyObserver()
    {

        for (int i = 0; i < observers.Count; i++) observers[i].update(); 

    }
    protected string name;
    protected float money;
    private List<Observer> observers = new List<Observer>(); 
}
