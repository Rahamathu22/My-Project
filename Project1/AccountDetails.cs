using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class AccountDetails
    {
        public string AccountNumber { get; set; }
        public int Password { get; set; }
        public double Balance { get; set; }
        public AccountDetails(string accountnumber,int password,double balance)
        {
            this.AccountNumber=accountnumber;
            this.Password=password;
            this.Balance = balance;
        }

        public void ChangePassword(int newPassword)
        {
            Password = newPassword;
        }
    }
}
