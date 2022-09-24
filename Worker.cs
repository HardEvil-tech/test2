﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp6
{
    internal class Worker
    {
       public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Worker (string name, int age, double salary)
        {
            Console.WriteLine("Worker full constructor ");
            Name = name;
            Age = age;
            Salary  = salary;

        }
        public Worker()
        {
            Console.WriteLine("Worker ddefault constructor");
        }

        public virtual double GetResultSalary()
        {
            return Salary;
        }
    }
}
