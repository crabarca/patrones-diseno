using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student factory creates only students
            var sortingClient = new SortingClient<Student>(new StudentFactory(), 10);
            sortingClient.Sort();

            // Groceries factory creates only groceries
            var sortingClient2 = new SortingClient<Groceries>(new GroceryFactory(), 10);
            sortingClient2.Sort();

            // To show that is possible to instantiate a single item (grocery or student)
            var studentFactory = new StudentFactory();
            Student student = studentFactory.BuildItem();

            var groceryFactory = new GroceryFactory();
            Groceries grocerie = groceryFactory.BuildItem();

            Console.WriteLine(student.Name);
            Console.WriteLine(grocerie.Name);
        }
    }
}