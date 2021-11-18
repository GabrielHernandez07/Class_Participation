using System;
using System.Collections.Generic;

namespace Classes_Toy
{
    public class Class
    {
        
        static void Main(string[] args)
        {
            List<ToyBox> Toyboxes = new List<ToyBox>();
            string YesorNo;
            do
            {
                ToyBox ToyBox1 = new ToyBox();
                Console.WriteLine("Who owns the toybox? >>");
                ToyBox1.Owner = Console.ReadLine();
                Console.WriteLine("Where is the toybox located? >>");
                ToyBox1.Location = Console.ReadLine();

                Toyboxes.Add(ToyBox1);

                Console.WriteLine("Do you have another toybox to enter? Yes or No? >>");
                YesorNo = Console.ReadLine();
                
            } while (YesorNo.ToLower() == "yes");

            for (int i = 0; i < Toyboxes.Count; i++)
            {
                Console.WriteLine($"Time to fill {Toyboxes[i].Owner}'s ToyBox w/ Toys!");

                do
                {
                    Toy ToyBox1 = new Toy();
                    Console.WriteLine("Enter Manufacturer of the Toy >>");
                    ToyBox1.Manufacturer = Console.ReadLine();
                    Console.WriteLine($"Enter the Name of the Toy made by {ToyBox1.Manufacturer} >>");
                    ToyBox1.Name = Console.ReadLine();
                    Console.WriteLine($"Enter the price of the {ToyBox1.Name}>>");
                    ToyBox1.Price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"What notes do you have for {ToyBox1.Name}? Seperate each one with a \\n");
                    ToyBox1.AddNote(Console.ReadLine());

                    Toyboxes[i].Toys.Add(ToyBox1);

                    Console.WriteLine($"Do you have another toy to enter for {Toyboxes[i].Owner}'s ToyBox? yes or no >>");
                } while (Console.ReadLine().ToLower()[0] == 'y');
            }

            foreach (ToyBox currentToyBox in Toyboxes)
            {
                Console.WriteLine($"{currentToyBox.Owner}'s ToyBox is located @ {currentToyBox.Location}.  The ToyBox has {currentToyBox.Toys.Count} toys inside of it:");
                foreach (Toy toyInCurrentBox in currentToyBox.Toys)
                {
                    Console.WriteLine();
                    Console.WriteLine(toyInCurrentBox);
                }

                Console.WriteLine("".PadLeft(10, '-') + "Random Toy!" + "".PadLeft(10, '-'));
                Toy randomToyFromToyBox = currentToyBox.GetRandomToy();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(randomToyFromToyBox);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            //Toy toy1 = new Toy();
            //toy1.Manufacturer = "Hasbro";
            //toy1.Name = "Mr.Potato Head";
            //toy1.Price = 14.99;
            //toy1.AddNote("Fun for all kids");
            //toy1.AddNote("Ages 4+");

            //Toy toy2 = new Toy("Mattel", "Barbie", 19.99,"Super fun");

            //Console.WriteLine(toy1);
            //Console.WriteLine(toy2);
        }
    }
}
