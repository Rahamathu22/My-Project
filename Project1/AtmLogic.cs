using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class AtmLogic
    {
      
       public List<AccountDetails> actd1{get;private set;}
        public AtmLogic ()
	    {
         actd1 = new List<AccountDetails>
         {
             new AccountDetails("9876543211",1234,5000),
             new AccountDetails("9876543212",1212,50000),
             new AccountDetails("9876543213",4321,8000),
             new AccountDetails("9876543214",2121,10000)
         };
         
             
	    }
        public AccountDetails GetAccountByNumber(string accountNumber)
              {
                  foreach (var account in actd1)
                   {
                     if (account.AccountNumber == accountNumber)
                      {
                         return account;
                      }
                   }
                    return null;
               }
        
    }
}
