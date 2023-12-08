using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Account Number:");
            double acno = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Pin Number:");
            int pin = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Account Balance:");
            int balance = int.Parse(Console.ReadLine());
            AutomatedMachine auto = new AutomatedMachine(acno, pin,balance);
            auto.Language();
        }
    }
}
