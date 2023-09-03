using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Bank
    {
        private double balance;

        public double getBalance() // Accessor.
        {
            return balance; 
        }

        public void setBalance(double balance) // Mutator.
        {
            if (balance < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Balance cannot be negative!");
            } else
            {
                this.balance = balance;
            }
        }
    }

    public class Bank2
    {
        private double balance;

        public double Balance {
            get
            {
                return balance;
            } 
            set 
            {
                if(value < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Balance cannot be negative!");
                } 
                else
                {
                    this.balance = value;
                }
            }
        }
    }
}
