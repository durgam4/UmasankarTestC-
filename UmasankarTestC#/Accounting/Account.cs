using System;
using System.Collections.Generic;
using System.Text;

namespace UmasankarTestC.Accounting
{
    public record  Account
    {
        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                accountNumber = value;
            }
            
        }

    }
}
