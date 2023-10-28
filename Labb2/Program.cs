namespace Labb2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Mouse mouseOne = new Mouse("Sven", 7, 2, "Brun", "Husmus", 4);
            Cat catOne = new Cat("Göran", 12, 10, "Vit", "Bondkatt", 28);
            Dog dogOne = new Dog("Erik", 18, 30, "Svart", "Labrador", "Fisk");
            Rat ratOne = new Rat("Kalle", 3, 5, "Svart-brun", "Kyrkråtta", 4, 10);
            Rat ratTwo = new Rat();
            Shrew shrewOne = new Shrew("Nils", 4, 1, "Grå", "Näbbmus", 4, 10);

            mouseOne.Race();
            mouseOne.NameAge();
            mouseOne.ColorWeight();
            mouseOne.MouseInfo();

            Console.WriteLine();

            catOne.Race();
            catOne.NameAge();
            catOne.ColorWeight();
            catOne.CatInfo();

            Console.WriteLine();

            dogOne.Race();
            dogOne.NameAge();
            dogOne.ColorWeight();
            dogOne.DogInfo();

            Console.WriteLine();

            ratOne.Race();
            ratOne.NameAge();
            ratOne.ColorWeight();
            ratOne.MouseInfo();
            ratOne.Cheese();

            Console.WriteLine();

            ratTwo.Race();
            ratTwo.NameAge();
            ratTwo.ColorWeight();
            ratTwo.MouseInfo();
            ratTwo.Cheese();

            Console.WriteLine();

            shrewOne.Race();
            shrewOne.NameAge();
            shrewOne.ColorWeight();
            shrewOne.MouseInfo();
            shrewOne.Babies();

        }
    }









}