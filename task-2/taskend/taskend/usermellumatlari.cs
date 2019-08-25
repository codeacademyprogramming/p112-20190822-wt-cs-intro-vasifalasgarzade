
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Usermellumatlari
    {
        public string firstName;

        public string lastName;

        public int idNumber;

        public int balance = 0;

        public Usermellumatlari(string firstName, string lastName, int idNumber)
        {
            this.updateCredentials(firstName, lastName, idNumber);
        }

        public void updateCredentials(string firstName, string lastName, int idNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.idNumber = idNumber;
        }

        public string FirstName()
        {
            return this.firstName;
        }

        public string LastName()
        {
            return this.lastName;
        }

        public int IdNumber()
        {
            return this.idNumber;
        }

        public int Balance()
        {
            return this.balance;
        }

        public void withdrawFromBalance(int hesab)
        {
            if (this.balance >= hesab)
            {
                this.balance = this.balance - hesab;
            }
        }

        public void addToBalance(int amount)
        {
            this.balance = this.balance + amount;
        }
    }
}
