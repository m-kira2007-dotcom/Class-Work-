using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public abstract partial class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public bool IsClaustrophobic { get; set; }

        public Pet()
        {

        }
    }
    public partial class Cat : Pet
    {
        public string FurColor { get; set; }
        public bool IsLazy { get; set; }

        public Cat()
        {

        }
    }
    public partial class Dog : Pet
    {
        public string Breed { get; set; } // порода 
        public bool KnowsCommands { get; set; }

        public Dog()
        {

        }
    }
    public partial class Rabbit : Pet
    {
        public double EarLength { get; set; }
        public bool IsDomestic { get; set; } // домашний 

        public Rabbit()
        {

        }
    }
    public partial class Parrot : Pet
    {
        public string Gender { get; set; }
        public bool IsTalking { get; set; }

        public Parrot()
        {

        }
    }


}
