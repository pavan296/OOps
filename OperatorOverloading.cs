using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs
{
    class OperatorOverloading
    {
        private int someValue;
        public OperatorOverloading(int val)
        {
            someValue = val;
        }
        public static OperatorOverloading operator +(OperatorOverloading arg1, OperatorOverloading arg2){
            return new OperatorOverloading(arg1.someValue + arg2.someValue);
            }

    }
}
