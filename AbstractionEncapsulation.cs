using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs
{
    class AbstractionEncapsulation
    {
        public string name { get; set; }
        public void Validate()
        {
            checkName();
        }
        public void checkName()
        {
            //functionality for validation
        }
    }
}
