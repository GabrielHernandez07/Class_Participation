using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Toy
{
    class ToyBox
    {
        public List<Toy> Toys { get; set; }
        public string Owner { get; set; }
        public string Location { get; set; }
        public ToyBox()
        {
            Toys = new List<Toy>();
            Owner = string.Empty;
            Location = string.Empty;
        }
        public Toy GetRandomToy()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, Toys.Count + 1);
            Toy randomToy = Toys[randomNumber];
            return randomToy;
            
        }
    }
}
