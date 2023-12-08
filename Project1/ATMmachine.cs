using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
   public class ATMmachine
    {
        double AccountNo;
        int PinNo;

        public ATMmachine(double AccountNo, int PinNo)
        {
            this.AccountNo = AccountNo;
            this.PinNo = PinNo;
        }

        public static int GetInteger(string message)
        {
            Console.WriteLine(message);
            int Number = int.Parse(Console.ReadLine());
            return Number;
        }

        public  void Language()
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
                        int demo = int.Parse(Console.ReadLine());
                        Console.WriteLine("1.yes");
                        Console.WriteLine("2.No");
                        int demo1=int.Parse(Console.ReadLine());
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
            if (PinNo = Password)
            {
            }
            else
            {
                Console.WriteLine("Incorrect pin Number");
                break;
            }
        }

    }
}
