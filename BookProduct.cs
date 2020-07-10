using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine
{
    public class BookProduct:PhysicalProduct
    {
        public BookProduct():base()
        {
            payment = new DuplicatePackingSlip();           
        }
    }
}
