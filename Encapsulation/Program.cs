using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Bank bank = new Bank();
            bank.setBalance(-1000);
            Console.WriteLine(bank.getBalance());
            Console.ReadLine();
            */

            Bank2 ubl = new Bank2();
            ubl.Balance = -1000;
            Console.WriteLine(ubl.Balance);
            Console.ReadLine();
        }
    }
}
