using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class AutomatedMachine
    {
        double AccountNo;
        int PinNo;

        double Balance;
       

        public AutomatedMachine(double AccountNo, int PinNo,double Balance)
        {
            this.AccountNo = AccountNo;
            this.PinNo = PinNo;
            this.Balance = Balance;
        }

       public static int GetInteger(string message)
        {
            Console.WriteLine(message);
            int Number = int.Parse(Console.ReadLine());
            return Number;
        }

        public void Language()
        {
            Console.WriteLine("LANGUAGE");
            Console.WriteLine("------------------");
            Console.WriteLine("1.English");
            Console.WriteLine("2.Tamil");
            int Number = GetInteger("Enter the number to select your Language:");
            switch (Number)
            {
                case 1:
                    {
                        Console.WriteLine("Enter any number between 10 and 99:");
                        Console.WriteLine("Eg.25");
                        int demo = int.Parse(Console.ReadLine());
                        Console.WriteLine("1.yes");
                        Console.WriteLine("2.No");
                        Console.WriteLine("Enter a number if you continue or exit:");
                        int demo1 = int.Parse(Console.ReadLine());
                        if (demo1 == 1)
                        {
                            Password();
                        }
                        else
                        {
                            break;
                        }
                        break;
                    }
                case 2:
                    {
                        break;
                    }
            }
        }


        private void Password()
        {
            int Password = GetInteger("Enter your pin number:");
            if (PinNo == Password)
            {
                Console.WriteLine("1.Change your ATM pin");
                Console.WriteLine("2.Fast Withdraw");
                Console.WriteLine("3.Cash Withdraw");
                Console.WriteLine("4.Check your balance");
                Console.WriteLine("5.Mini Statement");
                int operation = GetInteger("Enter the number to perform such operation:");
                    switch(operation)
                    {
                        case 1:
                            {
                                ChangePassword();
                                break;
                            }
                        case 2:
                            {
                                FastWithdraw();
                                break;
                            }
                        case 3:
                            {
                                CashWithdraw();
                                break;
                            }
                        case 4:
                            {
                                GetBalance();
                                break;
                            }
                        case 5:
                            {
                                break;
                            }
                    }

                    

            }
            else
            {
                Console.WriteLine("Incorrect pin Number");
                
            }
        }

        private void ChangePassword()
        {
            int OldPin = GetInteger("Enter your old pin:");
            int NewPin = GetInteger("Enter your new pin:");
            int ConfrimPin = GetInteger("Confrim your new pin:");
            if (NewPin == ConfrimPin)
            {
                PinNo = ConfrimPin;
            }
            else
            {
                Console.WriteLine("Your confrim pin is not matches the New pin");
            }
        }

        private void FastWithdraw()
        {
            Console.WriteLine("1.500");
            Console.WriteLine("2.2000");
            Console.WriteLine("3.5000");
            Console.WriteLine("4.10000");
            int num = GetInteger("Enter the number to select the amount:");
           
            Console.WriteLine("1.Confrim");
            Console.WriteLine("2.Exit");
            int choice = GetInteger("Enter the number to select your choice:");
            if (choice == 1)
            {
                switch (num)
                {
                    case 1:
                        {
                            if (Balance > 500)
                            {
                                Balance = Balance - 500;
                                Console.WriteLine("Please wait while we process your request");
                                Console.WriteLine("Please remove your card and get the cash");

                                Console.WriteLine("you want receipt fo your transaction");
                                Console.WriteLine("1.Yes");
                                Console.WriteLine("2.No");
                                int Choice = GetInteger("Enter the number to select your choise:");
                                if (Choice == 1)
                                {
                                    Console.WriteLine("Please collect your receipt");
                                    Console.WriteLine("Your balance is:"+Balance);
                                    Console.WriteLine("Thank You");
                                }
                                else
                                {
                                    Console.WriteLine("Thank You");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Insufficient fund");
                            }
                            break;
                        }
                    case 2:
                        {
                            if (Balance > 2000)
                            {
                                Balance = Balance - 2000;
                                Console.WriteLine("Please wait while we process your request");
                                Console.WriteLine("Please remove your card and get the cash");

                                Console.WriteLine("you want receipt fo your transaction");
                                Console.WriteLine("1.Yes");
                                Console.WriteLine("2.No");
                                int Choice = GetInteger("Enter the number to select your choise:");
                                if (Choice == 1)
                                {
                                    Console.WriteLine("Please collect your receipt");
                                    Console.WriteLine("Your balance is:" + Balance);
                                    Console.WriteLine("Thank You");
                                }
                                else
                                {
                                    Console.WriteLine("Thank You");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Insufficient fund");
                            }
                            break;
                        }
                    case 3:
                        {
                            if (Balance > 5000)
                            {
                                Balance = Balance - 5000;
                                Console.WriteLine("Please wait while we process your request");
                                Console.WriteLine("Please remove your card and get the cash");

                                Console.WriteLine("you want receipt fo your transaction");
                                Console.WriteLine("1.Yes");
                                Console.WriteLine("2.No");
                                int Choice = GetInteger("Enter the number to select your choise:");
                                if (Choice == 1)
                                {
                                    Console.WriteLine("Please collect your receipt");
                                    Console.WriteLine("Your balance is:" + Balance);
                                    Console.WriteLine("Thank You");
                                }
                                else
                                {
                                    Console.WriteLine("Thank You");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Insufficient fund");
                            }
                            break;
                        }
                    case 4:
                        {
                            if (Balance > 10000)
                            {
                                Balance = Balance - 10000;
                                Console.WriteLine("Please wait while we process your request");
                                Console.WriteLine("Please remove your card and get the cash");

                                Console.WriteLine("you want receipt fo your transaction");
                                Console.WriteLine("1.Yes");
                                Console.WriteLine("2.No");
                                int Choice = GetInteger("Enter the number to select your choise:");
                                if (Choice == 1)
                                {
                                    Console.WriteLine("Please collect your receipt");
                                    Console.WriteLine("Your balance is:" + Balance);
                                    Console.WriteLine("Thank You");
                                }
                                else
                                {
                                    Console.WriteLine("Thank You");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Insufficient fund");
                            }
                            break;
                        }
                }
                

            }
            else
            {
                Console.WriteLine("Thank You");
            }
        }

        private void CashWithdraw()
        {
            Console.WriteLine("1.Current Account");
            Console.WriteLine("2.Savings Account");
            Console.WriteLine("3.Credit Card");
            int Value = GetInteger("Enter the number to perform the operation:");
            switch (Value)
            {
                case 1:
                    {

                        CurrentAccount();
                        break;
                    }
                case 2:
                    {
                        SavingsAccount();
                        break;
                    }
                case 3:
                    {
                        CreditCard();
                        break;
                    }
            }
        }

        private void CurrentAccount()
        {
            Console.WriteLine("Available Denomination:(100,200,500)");
            Console.WriteLine("********************************************");
            int Cash = GetInteger("Enter the amount you wish to withdraw:");
            

            Console.WriteLine("1.Confrim");
            Console.WriteLine("2.Exit");
            int num = GetInteger("Enter the number to select your choice");
            if (num == 1)
            {
                if (Balance > Cash)
                {
                    Balance = Balance - Cash;
                    Console.WriteLine("Please wait while we process your request");
                    Console.WriteLine("Please remove your card and get your cash");
                    Console.WriteLine("You want receipt for your transaction");
                    Console.WriteLine("1.Yes");
                    Console.WriteLine("2.No");
                    int choice = GetInteger("Enter the number to select your choice");
                    if (choice == 1)
                    {
                        Console.WriteLine("Please collect your receipt");
                        Console.WriteLine("Your balance is:" + Balance);
                        Console.WriteLine("Thank You");
                    }
                    else
                    {
                        Console.WriteLine("Thank You");
                    }
                }
                else
                {
                    Console.WriteLine("Insufficient fund");
                }
                

            }
            else
            {
                Console.WriteLine("Thank You");
            }
        }

        private void SavingsAccount()
        {
            CurrentAccount();
        }

        private void CreditCard()
        {
            CurrentAccount();
        }

        private void GetBalance()
        {
            Console.WriteLine("Your Balance is:"+Balance);
        }

        private void PrintMiniStatement(AutomatedMachine atm)
        {
            List<AutomatedMachine> atmlist = new List<AutomatedMachine>();
            atmlist.Add(atm);
        }

    }
}
