using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs
{
    public abstract class AbstractClassCustomer
    {
        public string name { get; set; }
        public decimal productAmount { get; set; }
        public abstract decimal CalculateDiscount();
        //square,triangle etc have common functionality shape but different perimeter and area so we can define abstr
        //methods of perimeter and area but shape calss whould be abstract.
    }

    public class GoldCustomer : AbstractClassCustomer
    {
        public override decimal CalculateDiscount()
        {
            return productAmount - 10;
        }
    }
    public class SilverCustomer : AbstractClassCustomer
    {
        public override decimal CalculateDiscount()
        {
            return productAmount - 20;
        }
    }
}
