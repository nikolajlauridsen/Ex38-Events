using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kraftwerk.cs
{
    public delegate void EventHandler(object sender, EventArgs e);
    
    public class EmployeeArgs: EventArgs
    {
        public string Message;
    }

    public class Employee
    {
        public readonly string Name;
        private event EventHandler<EmployeeArgs> pulse;

        public Employee(string name)
        {
            Name = name;
        }

        public void ShowLifeSign()
        {
            EmployeeArgs args = new EmployeeArgs { Message = $"For the record: {Name} is alive" };
            pulse(this, args);
        }

        public void RegisterSensor(EventHandler<EmployeeArgs> handler)
        {
            pulse += handler;
        }
    }
}
