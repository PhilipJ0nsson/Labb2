using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labb2
{

    internal class Mouse : Animal
    {

        public int _legs;

        public Mouse() : this("No data provided.", 00, 00, "No data provided.", "No data provided.", 00)
        {

        }

        public Mouse(string name, int age, int weight, string color, string race, int legs) : base(name, age, weight, color, race)
        {

            _legs = legs;

        }


        public virtual void MouseInfo()
        {
            Console.Write("Musen låter: ");
            MakeSound();
            Console.Write("Musen har: ");
            Legs();
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("meeeeep meeeeeeeeep!");
        }
        public void Legs()
        {
            Console.WriteLine(_legs + " ben");
        }
    }

}
