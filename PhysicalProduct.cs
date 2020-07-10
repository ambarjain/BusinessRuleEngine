using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine
{
    public class PhysicalProduct:Product
    {
        public PhysicalProduct()
        {
            payment = new PackingSlip();
        }
        

    }
}
