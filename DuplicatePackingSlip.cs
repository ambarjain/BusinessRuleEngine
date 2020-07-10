using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine
{
    internal class DuplicatePackingSlip : IPayment
    {
        public string MakePayment()
        {
            return "Generating Duplicate Packing SLip for Royalty Department";
        }
    }
}
