using System;

namespace Classes_Toy
{
    public class Class
    {
        
        static void Main(string[] args)
        {
            Toy toy1 = new Toy();
            toy1.Manufacturer = "Hasbro";
            toy1.Name = "Mr.Potato Head";
            toy1.Price = 14.99;
            toy1.AddNote("Fun for all kids");
            toy1.AddNote("Ages 4+");

            Toy toy2 = new Toy("Mattel", "Barbie", 19.99,"Super fun");

            Console.WriteLine(toy1);
            Console.WriteLine(toy2);
        }
    }
}
