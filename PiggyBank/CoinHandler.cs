using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public class CoinHandler
    {
        private double unitPrice = 595;
        private int lastCount = 0;

        public void ShowTotal(object sender, CoinEvent e)
        {
            PiggyBank bank = (PiggyBank)sender;
            Console.WriteLine($"{e.amountAdded} added to the piggybank, new total: {bank.Saldo}");
        }

        public void NotifyTicketCount(object sender, EventArgs e)
        {
            int ticketCount;
            PiggyBank bank = (PiggyBank)sender;

            ticketCount = (int)(bank.Saldo / unitPrice);

            if (ticketCount > lastCount) {
                Console.WriteLine($"Tillykke – du har nu penge nok til {ticketCount} sæsonkort til OBs kampe");
                lastCount = ticketCount;
            }
        }
    }
}
