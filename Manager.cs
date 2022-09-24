using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp6
{
    internal class Manager : Worker
    {
        public int CLientCount { get; set; }

        public Manager(string name, int age, double salary, int clientcount)
            : base(name, age, salary)
        {
            Console.WriteLine("Manager full constructor");
            CLientCount = clientcount;
        }
        public Manager() : base()
        {
            Console.WriteLine("Manager default costructor");
        }

        public override double GetResultSalary()
        {
            return Salary*CLientCount;
        }
    }
}
