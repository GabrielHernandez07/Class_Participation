using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Toy
{
    public class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Notes { get; set; }
        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Notes = string.Empty;
        }
        public Toy(string note)
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Notes = string.Empty;
        }
        public Toy(string manufacturer, string name, double price, string note)
        {
            Manufacturer = manufacturer;
            Name = name;
            Price = price;
            Notes = note;
        }
        public void AddNote(string note)
        {
            if (string.IsNullOrEmpty(Notes) == true)
            {
                Notes = note;
            }
            else
            {
                    Notes += "\n" + note;
            }
        }
        public string ReturnNote()
        {
            return Notes;
        }
        public string GetAisle()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 25);
            string manuFirstLetter = Manufacturer;
            manuFirstLetter = "" + manuFirstLetter.ToUpper()[0];
            string manuLetterandNumber = $"{manuFirstLetter}{randomNumber}";
            return manuLetterandNumber;
        }
        public override string ToString()
        {  
            return $"{Name} is made by {Manufacturer} and costs {Price.ToString("C")} and can be found on aisle {GetAisle()}. {Notes}"; ;
        }
    }
}
