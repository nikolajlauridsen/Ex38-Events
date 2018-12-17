using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex38_Events
{
    public class Metronome
    {
        private event TickDelegate Tick;

        public void RegisterTick(TickDelegate listener)
        {
            Tick += listener;
        }

        public void DoTick(int BPM, int bars, int notePrBar = 4)
        {
            int delay = 60000 / BPM;
            double count = bars * notePrBar;

            Console.WriteLine($"BPM: {BPM}\tDelay: {delay} MS");
            for(int i=0; i < count; i++) {
                Console.WriteLine("Tick!");
                Tick();
                System.Threading.Thread.Sleep(delay);
            }
        }
    }
}
