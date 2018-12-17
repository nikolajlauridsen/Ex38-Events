using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to piggybank inc");

            PiggyBank bank = new PiggyBank();
            CoinHandler handler = new CoinHandler();

            bank.RegisterHandler(handler.ShowTotal);
            bank.RegisterHandler(handler.NotifyTicketCount);

            bool valid, insert = true;
            double amount = 0;

            while(insert == true) {
                Console.Write("Enter amount to add to the piggybank: ");
                valid = Double.TryParse(Console.ReadLine(), out amount);
                Console.WriteLine();

                if (valid && amount > 0) {

                    bank.InsertCoins(amount);
                } else if (valid && amount == 0) {
                    insert = false;
                } else {
                    Console.WriteLine("Invalid input, try again");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Thanks for visiting piggybank inc.");

            Console.ReadKey(); 
        }
    }
}
