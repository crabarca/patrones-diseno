using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client("Alberto", new RegularMembership());
            var subtotal = 100_000;
            var total = subtotal * client.MultiplierDiscount();
            
            Console.WriteLine($"Total is : {total}");
            
            client.MembershipType = new PremiumMembership();

            total = subtotal * client.MultiplierDiscount();
            Console.WriteLine($"Total is : {total}");

        }
    }
}