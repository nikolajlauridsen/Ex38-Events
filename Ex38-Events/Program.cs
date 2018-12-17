using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex38_Events
{
    public delegate void TickDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            Metronome metronome = new Metronome();
            TickListener listener = new TickListener();

            metronome.RegisterTick(listener.ListenTick);
            metronome.DoTick(130, 4);
        }
    }
}
