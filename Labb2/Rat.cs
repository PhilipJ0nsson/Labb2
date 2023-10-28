using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    internal class Rat : Mouse
    {
        public int _cheese;

        public Rat() : this ("No data provided.", 00, 00, "No data provided.", "No data provided.",00,00)
        {

        }

        public Rat(string name, int age, int weight, string color, string race, int legs, int cheese) : base(name, age, weight, color, race, legs)
        {

            _cheese = cheese;

        }

        public override void MouseInfo()
        {
            Console.Write("Råttan låter: ");
            MakeSound();
            Console.Write("Råttan har: ");
            Legs();
        }
        public override void MakeSound()
        {
            Console.WriteLine("mooooop mooooooooop!");
        }

        public void Cheese()
        {
            Console.WriteLine($"Råttan har {_cheese} ostar.");
        }
    }
}

