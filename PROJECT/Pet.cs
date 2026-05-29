using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    // Атрибуты [JsonDerivedType] больше не нужны! Newtonsoft сделает всё сам.
    public abstract partial class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public Pet()
        {

        }
        public Pet(string name, int age, double weight, double height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
        }
    }

    public partial class Cat : Pet
    {
        public bool IsLazy { get; set; }
        public string FurColor { get; set; }
        public Cat()
        {

        }
        public Cat(string name, int age, double weight, double height, bool isLazy, string Color) : base(name, age, weight, height)
        {
            IsLazy = isLazy;
            FurColor = Color;

        }
    }

    public partial class Dog : Pet
    {
        public string Breed { get; set; }
        public bool KnowsCommands { get; set; }
        public Dog()
        {

        }
        public Dog(string name, int age, double weight, double height, string breed, bool knowsCommands) : base(name, age, weight, height)
        {
            Breed = breed;
            KnowsCommands = knowsCommands;
        }
    }

    public partial class Rabbit : Pet
    {
        public double EarLength { get; set; }
        public bool IsDomestic { get; set; }
        public Rabbit()
        {

        }
        public Rabbit(string name, int age, double weight, double height, double earLength, bool isDomestic) : base(name, age, weight, height)
        {
            EarLength = earLength;
            IsDomestic = isDomestic;
        }
    }
    public partial class Parrot : Pet
    {
        public bool IsTalking { get; set; }
        public string Gender { get; set; }
        public Parrot()
        {

        }
        public Parrot(string name, int age, double weight, double height, bool isTalking, string gender) : base(name, age, weight, height)
        {
            Gender = gender;
            IsTalking = isTalking;
        }
    }
}
