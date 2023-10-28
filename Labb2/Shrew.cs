using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    internal class Shrew : Mouse
    {

        public int _babies;

        public Shrew() : this("No data provided.", 00, 00, "No data provided.", "No data provided.", 00, 00)
        {

        }

        public Shrew(string name, int age, int weight, string color, string race, int legs, int babies) : base(name, age, weight, color, race, legs)
        {

            _babies = babies;

        }


        public override void MouseInfo()
        {
            Console.Write("Näbbmusen låter: ");
            MakeSound();
            Console.Write("Näbbmusen har: ");
            Legs();
        }
        public override void MakeSound()
        {
            Console.WriteLine("miiiiiip miiiiiip!");
        }
        public void Babies()
        {
            Console.WriteLine("Näbbmusen har " + _babies + " barn");
        }
    }

}
    

