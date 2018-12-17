using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kraftwerk.cs
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Sensor lifeSensor = new Sensor();
            
            Employee e1 = new Employee("Bob");
            Employee e2 = new Employee("Tessa");
            Employee e3 = new Employee("Jay");

            e1.RegisterSensor(lifeSensor.ListenLifesign);
            e2.RegisterSensor(lifeSensor.ListenLifesign);
            e3.RegisterSensor(lifeSensor.ListenLifesign);

            e1.RegisterSensor(lifeSensor.ListenSignal);
            e2.RegisterSensor(lifeSensor.ListenSignal);
            e3.RegisterSensor(lifeSensor.ListenSignal);

            Console.WriteLine("Running simulation for 10 seconds");

            for(int i =0; i<10; i++) {
                Console.WriteLine($"Triggering event {i + 1}");
                e1.ShowLifeSign();
                e2.ShowLifeSign();
                e3.ShowLifeSign();
                Console.WriteLine();
                System.Threading.Thread.Sleep(1000);
            }

            // The code provided will print ‘Hello World’ to the console;
            Console.ReadKey();
        }
    }
}
