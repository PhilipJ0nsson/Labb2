using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{

    internal class Animal
    {
        public string _name;
        public int _age;
        public int _weight;
        public string _color;
        public string _race;

        public Animal(): this ("No data provided.", 00, 00, "No data provided.", "No data provided.")
        { 
        }


        public Animal(string name, int age, int weight, string color, string race)
        {
            _name = name;
            _age = age;
            _weight = weight;
            _color = color;
            _race = race;
        }

        public void Race()
        {
            Console.WriteLine($"Art: {_race}");
        }
        public void NameAge()
        {
            Console.WriteLine($"Han/Hon heter {_name} och är {_age} år gammal.");
        }
        public void ColorWeight()
        {
            Console.WriteLine($"Den har färgen {_color} och väger {_weight} kilo.");
        }



    }

}
