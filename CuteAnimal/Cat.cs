using System;
using System.Data;
using System.Net.Http.Headers;
using System.Numerics;

namespace CuteAnimal
{
    public class Cat
    {

        public CatType type { get; set; }
        public Feed hungry { get; set; }
        public Mood mood { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }
        private int age;
        public int Age
        {
            get => age;
            
            set
            {
                if (value >= 1 && value < 18)
                    age = value;
            }
        }

        private Cat()
        {
            Random random = new Random();
            Age = random.Next(1, 18);
            Weight = (float)random.NextDouble() * (/*Max Value*/ 100f - /*Min Value*/ 0.4f) + 0.4f;
            Height = random.Next(10, 130);
            type = (CatType)random.Next(0, 5);
            hungry = (Feed)random.Next(0, 5);
            mood = (Mood)random.Next(0, 4);
        }

        public Cat(string catName, int height, float weight, int catage, Mood catMood, CatType catType, Feed catHungry)
        {
            Name = catName;
            Height = height;
            Weight = weight;
            Age = age;
            mood = catMood;
            type = catType;
            hungry = catHungry;
        }

        public Cat(string catName) : this()
        {
            Name = catName;
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