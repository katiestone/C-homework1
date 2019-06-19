using System;
using System.Collections.Generic;
using System.Text;

namespace Accounts
{
    class AccountItem
    {
        public string name;
        public Categoy categoy;
        public string cotent;
        public string note;
        public Money money;
        public DateTime occuredTime;
    }

    public enum Categoy {
        Spending = 1,
        Income =2
    }
}
