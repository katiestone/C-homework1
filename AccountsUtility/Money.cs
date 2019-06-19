using System;
using System.Collections.Generic;
using System.Text;

namespace Accounts
{
    public class Money
    {
        public Currency currency;

        public double amount;

        public Money(Currency currency, float num) {
            this.currency = currency;
            this.amount = num;
        }

        public static Money operator +(Money money1, Money money2) 
        {
            money1.amount += money2.amount;
            return money1;
        }

        public static Money operator -(Money money1, Money money2)
        {
            money1.amount -= money2.amount;
            return money1;
        }
    }

    public enum Currency {
        CYN = 1,
        USD = 2,
        Yen = 3
    }
}
