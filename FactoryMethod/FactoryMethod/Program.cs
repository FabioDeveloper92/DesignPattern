using FactoryMethod.ConcreteCreator;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogCreator = new DogCreator();
            var myDog = dogCreator.Create("Toby");
            Console.WriteLine(myDog.SayHello());

            var catCreator = new CatCreator();
            var myCat = catCreator.Create("Kitty");
            Console.WriteLine(myCat.SayHello());
        }
    }
}
