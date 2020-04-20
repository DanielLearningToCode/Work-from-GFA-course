using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace Bank_of_Simba.Models
{
    public enum Characters { Good_guy, Bad_guy }
    public class BankAccount
    {
        public string Name { get; set; }
        public decimal Balance { get;  set; }
        public string AnimalType { get; set; }
        public bool King { get; set; }
        public Characters Character { get; set; }


        public BankAccount(string name, decimal balance, string animalType, bool king, Characters character)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            King = king;
            Character = character;
        }

        public BankAccount()
        {
        }
        public void IncreaseBalance()
        {
            if (King)
            {
                Balance += 100;
            }
            else
            {
                Balance += 10;
            }
        }
    }
}