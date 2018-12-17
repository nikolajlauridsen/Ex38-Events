using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public delegate void EventHandler(object sender, EventArgs e);

    public class CoinEvent : EventArgs
    {
        public double amountAdded;
    }

    class PiggyBank
    {
        public double Saldo { get; private set; }
        private event EventHandler<CoinEvent> coinEvent;
        
        public void InsertCoins(double amount)
        {
            Saldo += amount;
            coinEvent(this, new CoinEvent { amountAdded = amount });
        }

        public void RegisterHandler(EventHandler<CoinEvent> handler)
        {
            coinEvent += handler;
        }
    }
}
