using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs
{
    public interface ICustomer
    {
        //can interface has logic : No only definition
        //can we define access modifiers: always public
        string name { get; set; }
        string address { get; set; }
        string productName { get; set; }
        decimal productAmount { get; set; }
        decimal CalculateDiscount();
    }
    //if you want to change current interface then go tiwth new interface by inheriting old interfcae thru MULTIPLE inheritance
    public interface IcustomerInterest : ICustomer
    {
        decimal CalculateInterest();
    }


    public abstract class Customer:ICustomer,IcustomerInterest
    {
        public string address { get; set; }
        public string productName { get; set; }
        public string name { get; set; }
        public decimal productAmount { get; set; }
        public abstract decimal CalculateDiscount();
        public decimal CalculateInterest()
        {
            return 0;
        }
        //square,triangle etc have common functionality shape but different perimeter and area so we can define abstr
        //methods of perimeter and area but shape calss whould be abstract.
    }

    public class GoldCustomer1 : Customer
    {
        public override decimal CalculateDiscount()
        {
            return productAmount - 10;
        }
    }
    public class SilverCustomer1 : Customer
    {
        public override decimal CalculateDiscount()
        {
            return productAmount - 20;
        }
    }
}
