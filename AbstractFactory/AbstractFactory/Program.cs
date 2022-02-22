using AbstractFactory.Client;
using AbstractFactory.ConcreteFactory;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var boot = new Boot();
            var bootClient = new UserClient(boot);

            Console.WriteLine("Boot:");
            Console.WriteLine("Color => " + bootClient.GetColor());
            Console.WriteLine("Brand Name => " + bootClient.GetBrandName());

            Console.WriteLine("------");

            var sneakerUser = new Sneaker();
            var sneakerUserClient = new UserClient(sneakerUser);

            Console.WriteLine("Sneaker:");
            Console.WriteLine("Color => " + sneakerUserClient.GetColor());
            Console.WriteLine("Brand Name => " + sneakerUserClient.GetBrandName());
        }
    }
}
