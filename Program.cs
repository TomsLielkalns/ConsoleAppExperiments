using System;
using System.Collections.Generic;

namespace ConsoleAppExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> persons = new List<Human>();
            persons.Add(new Human("Jenifer", "Lopez", 25, "Brown"));
            persons.Add(new Human("Anna", "Smith", 15, "White"));
            persons.Add(new Human("Mikelis", "Zalkajis", 17, "Green"));
            persons.Add(new Human("Agnese", "Williams", 19, "Red"));

            //persons[1].SetAge(14);

            foreach(var person in persons)
            {
                person.Introduce();
            }

            //create some accounts
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new BankAccount("Jenifer", 200, "EUR"));
            accounts[0].PrintInfo();
            accounts.Add(new BankAccount("Anna", 5000, "EUR"));
            accounts[1].PrintInfo();
            accounts.Add(new BankAccount("Michael", 450, "EUR"));
            accounts[2].PrintInfo();
        }
    }
}
