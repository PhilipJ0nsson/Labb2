using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labb2
{

    internal class Dog : Animal
    {

        public string _food;

        public Dog() : this("No data provided.", 00, 00, "No data provided.", "No data provided.", "No data provided")
        {

        }

        public Dog(string name, int age, int weight, string color, string race, string food) : base(name, age, weight, color, race)
        {
            _food = food;
        }


        public void DogInfo()
        {
            Console.Write("Hunden låter: ");
            MakeSound();
            Food();
        }
        public void MakeSound()
        {
            Console.WriteLine("Voff voff!");
        }

        public void Food()
        {
            Console.WriteLine($"Hunden gillar att äta {_food}");
        }
    }

}
