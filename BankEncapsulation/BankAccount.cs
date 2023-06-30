using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double balance = 0;

        public void Deposit(double money) 
        {
            balance = money;        
        }
        public void GetBalance()
        {
            Console.WriteLine($"The balance in your account is ${ balance }");
        }
    }
}
