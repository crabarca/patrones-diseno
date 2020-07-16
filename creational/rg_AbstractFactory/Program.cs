using System;

namespace rg_AbstractFactory
{


    class Client
    {
        public void Main()
        {
            Console.WriteLine("Creating Factory 1");
            // IAbstractFactory factory1 = new Factory1();
            ClientMethod(new Factory1());

            Console.WriteLine("Creating Factory 2");
            // IAbstractFactory factory2 = new Factory2();
            ClientMethod(new Factory2());
        }
        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productA.printProductA());
            Console.WriteLine(productB.printProductB());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}
