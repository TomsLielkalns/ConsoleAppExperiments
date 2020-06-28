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
            accounts.Add(new BankAccount("Anna", 5000, "EUR"));
            accounts.Add(new BankAccount("Michael", 450, "EUR"));

            foreach (var account in accounts)
            {
                account.PrintInfo();
            }

            //make some transactions for jenifer
            accounts[0].MakeDeposit(100, "Birthday gift");
            accounts[0].MakeDeposit(400, "First salary");
            accounts[0].MakeDeposit(50, "Bonus");
            Console.WriteLine(accounts[0].Balance);
            accounts[0].MakeWithdrawal(150, "Online course");
            Console.WriteLine(accounts[0].Balance);
            accounts[0].MakeWithdrawal(1500, "Online shopping");
            Console.WriteLine(accounts[0].Balance);
        }
    }
}
