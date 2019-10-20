using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignByContract
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            var deposit = account.Deposit(100);
            Console.WriteLine($"Balance is now  {deposit} ");
   
            // Throws exception
            //var withdraw = account.Withdraw(1200);
            Console.ReadLine();

        }
    }
}
