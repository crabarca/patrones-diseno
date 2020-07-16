using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Groceryorting client
            var grocerySortingClient = new GrocerySortingClient(10);
            grocerySortingClient.Sort();

            // Student sorting client
            var studentSorting = new StudentSortingClient(5);
            studentSorting.Sort();
        }
    }
}