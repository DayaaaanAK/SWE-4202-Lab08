using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask08
{
    internal class Current_Account : Account
    {
        public static int account_id = 1;
        public static int max_transaction=100000;
        public Current_Account(string name, string id, int balance)
        {
            this.name = name;
            this.id = id;
            this.balance = balance;
        }
    }
}
