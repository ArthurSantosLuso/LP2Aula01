using System;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace CuteAnimal
{
    public class Program
    {


        private static void Main(string[] args)
        {
            Cat a = new Cat("pandora");
            Cat b = new Cat("cassi", 12, 12.2f, 1, Mood.Grumpy, CatType.MaineCoon, Feed.Full);

            Console.WriteLine(a.type);
            Console.WriteLine(b.type);
        }
    }
}
