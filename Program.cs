using System;

namespace BusinessRulesEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Purchased a physical product");
            Product physicalProduct = new PhysicalProduct();
            Console.WriteLine(physicalProduct.DoPayment());
            physicalProduct.setDifferentPaymentMethod(new CommissionPayment());
            Console.WriteLine(physicalProduct.DoPayment() + "\n");

            Console.WriteLine("Purchased a book");
            Product bookProduct = new BookProduct();
            Console.WriteLine(bookProduct.DoPayment());
            bookProduct.setDifferentPaymentMethod(new CommissionPayment());
            Console.WriteLine(bookProduct.DoPayment()+"\n");

            Console.WriteLine("Purchased a new membership");
            Product membership = new Membership("new");
            Console.WriteLine(membership.DoPayment()+"\n");


            Console.WriteLine("Upgraded a membership");
            Product membershipUpgrade = new Membership("upgrade");
            Console.WriteLine(membershipUpgrade.DoPayment()+"\n");

            Console.WriteLine("Purchased a Video");
            Product video = new LearningToSki();
            Console.WriteLine(video.DoPayment()+"\n");
        }
    }
}
