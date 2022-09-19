using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs
{
    internal class Employee
    {
        public string address { get; set; }
        public  virtual void Validate()
        {
            Console.WriteLine("Parent validate method");
        }
    }
    class VirtualOverride : Employee
    {
        public override void Validate()
        {
            //our own logic
            Console.WriteLine("Child validate method");
        }
        public void Validate(bool strict)
        {
            //our own logic
            Console.WriteLine("Child validate method");
        }
        public void Validate(bool strict, string name)
        {
            //our own logic
            Console.WriteLine("Child validate method");
        }
    }
}
