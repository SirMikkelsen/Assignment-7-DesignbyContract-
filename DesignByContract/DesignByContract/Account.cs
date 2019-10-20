using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignByContract
{
    public class Account
    {
        public double _balance = 1000;

        
        public double Deposit(double amount)
        {
            Contract.Requires(amount > 0, "amount must ");
            Contract.Ensures(Contract.Result<double>() >= 0);

            if (amount <0)
            {
                throw  new ArgumentException("amount must not be negativ");
            }

            return amount + _balance;
        }


        public double Withdraw( double amount)
        {
            Contract.Requires(amount > 0);
            Contract.Requires(_balance > amount);
            Contract.Ensures(Contract.Result<double>() >= 0);
            if (amount > _balance)
            {
                throw new ArgumentException("ammount is to high");
            }

            return _balance - amount;

        }
    }
}
