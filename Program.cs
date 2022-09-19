using OOPs;
using System;


namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor e1 = new Doctor();
            e1.Name = "Pavan";

            //Encapsulation(execution phase) implemnets abstraction(design phase)
            AbstractionEncapsulation e2 = new AbstractionEncapsulation();
            //uncomment and show difference between public and private access modifiers
            //e2.

            //Inheritance defines parent and child relationship of classes
            Inheritance e3 = new Inheritance();
            //uncomment and show how Inheritance class inherited characters from parent class called Doctor
            //e3.

            VirtualOverride e4 = new VirtualOverride();
            //uncomment and show how overloading vs overriding
            //e4

            //Polymorphism exist only inheritance relationship
            Employee1 e5 = new Manager();
            e5.Validate();
            e5 = new Supervisor();
            e5.Validate();
            //Static poly: implemneted by method overloading
            //Dynamic ploy: implmented by method overriding

            //Custom operator overloading
            var o1 = new OperatorOverloading(10);
            var o2 = new OperatorOverloading(20);
            var o3 = o1 + o2;

            //Abstract class:partially defined parent class
            //Cannot create instance for abstract class
            //purpose: Core functionality and common things put in one class to inherit in different modules

            //Interface: its a contract and legal binding b/w devloper class nd consumer using that class
            ICustomer x = new GoldCustomer1();
            x.name = "sss";
            x.productAmount = 100;
            x.CalculateDiscount();

            ICustomer x1 = new GoldCustomer1();
            
            x1.CalculateDiscount();
            IcustomerInterest x2 = new GoldCustomer1();
            x2.CalculateDiscount();
            x2.CalculateInterest();

            Console.WriteLine("Hello World!!");
        }
    }
    
}
