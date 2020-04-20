using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank_of_Simba.Models
{
    public class BankAccount
    {
        public string Name { get; private set; }
        public decimal Balance { get; private set; }
        public string AnimalType { get; private set; }
        public bool King { get; private set; }


        public BankAccount(string name, decimal balance, string animalType, bool king)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            King = king;
        }

        public BankAccount()
        {
        }
    }
}