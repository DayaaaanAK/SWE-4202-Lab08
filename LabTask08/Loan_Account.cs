using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask08
{
    internal class Loan_Account : Account
    {
        public static int account_id = 1;
        public double loan;
        public Loan_Account(string name, string id, double loan)
        {
            this.name = name;
            this.id = id;
            this.loan = loan;
        }
    }
}
