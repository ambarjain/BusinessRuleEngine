namespace BusinessRulesEngine
{
    internal class PackingSlip : IPayment
    {
        public string MakePayment()
        {
            return "Generating Packing Slip";
        }
    }
}