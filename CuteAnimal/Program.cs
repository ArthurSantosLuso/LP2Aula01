using System;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace CuteAnimal
{
    public class Program
    {
        private CatType type;
        private Feed hungry;
        private Mood mood;
        private Vector3 dimensions;
        private string name;
        private float weight;
        private int age;

        private static void Main(string[] args)
        {

        }

        private void MakeSound()
        {
            
            Random randNumber = new Random();
            int a = randNumber.Next(0, 3);

            switch (a)
            {
                case 0:
                    Console.WriteLine("Meow!");
                    break;
                case 1:
                    Console.WriteLine("purr!");
                    break;
                case 2:
                    Console.WriteLine("grr!");
                    break;
            }
        }
    }
}
