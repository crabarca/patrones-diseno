using System;

namespace rg_Prototype
{
    class IdInfo
    {
        public int Number;
        public IdInfo(int number){
            this.Number = number;
        }
    }
    class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public  IdInfo IdInfo;


        public Person ShallowCopy()
        {
            return (Person) this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person person = (Person) this.MemberwiseClone();
            person.IdInfo = new IdInfo(IdInfo.Number);
            return person;
        }
    }

    class Program
    {
        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}", p.Name, p.Age);
            Console.WriteLine("      Value: {0:d}", p.IdInfo.Number);
        }

        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Age = 20;
            person1.Name = "Nico";
            person1.IdInfo = new IdInfo(123);

            // Perform a shallow copy of p1 and assign it to p2.
            Person person2 = person1.ShallowCopy();

            // Display values of p1, p2
            Console.WriteLine("Original values of p1 and p2:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(person1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(person2);

            // Change the value of p1 properties and display the values of p1 and p2.
            person1.Age = 25;
            person1.Name = "Cristobal";
            person1.IdInfo.Number = 7878;
            Console.WriteLine("\nValues of p1 and p2 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(person1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(person2);

            // Make a deep copy of p1 and assign it to p3.
            Person person3 = person1.DeepCopy();
            // Change the members of the p1 class to new values to show the deep copy.
            person1.Name = "Sebastian";
            person1.Age = 26;
            // person1.IdInfo.Number = 8641;
            Console.WriteLine("\nValues of p1 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(person1);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(person3);
        }
    }
}
