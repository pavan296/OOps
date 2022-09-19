using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs
{
    class Employee1
    { 
        public virtual void Validate()
        {
            Console.WriteLine("Employee ");
        }
    }
    class Manager:Employee1
    {
        public override void Validate()
        {
            Console.WriteLine("Manager ");
        }
    }
    class Supervisor : Employee1
    {
        public override void Validate()
        {
            //our own logic
            Console.WriteLine("Supervisor");
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
