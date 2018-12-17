using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kraftwerk.cs
{
    public class Sensor
    {
        public void ListenLifesign(object sender, EmployeeArgs args)
        {
            Console.WriteLine(args.Message);
        }

        public void ListenSignal(object sender, EmployeeArgs args)
        {
            Employee employ = (Employee)sender;
            Console.WriteLine($"Bip from {employ.Name}");
        }
    }
}
