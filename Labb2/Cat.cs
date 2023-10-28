using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labb2
{

    internal class Cat : Animal
    {

        public int _whiskers;

        public Cat() : this("No data provided.", 00, 00, "No data provided.", "No data provided.", 00)
        {

        }

        public Cat(string name, int age, int weight, string color, string race, int whiskers) : base(name, age, weight, color, race)
        {

            _whiskers = whiskers;

        }

        public void CatInfo()
        {
            Console.Write("Katten låter: ");
            MakeSound();
            Whiskers();
        }
        public void MakeSound()
        {
            Console.WriteLine("Mjau mjau!");
        }

        public void Whiskers()
        {
            Console.WriteLine("Katten har " + _whiskers + " morrhår.");
        }
    }

}
