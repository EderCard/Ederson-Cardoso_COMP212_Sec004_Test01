using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ederson_Cardoso_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice[] invoice =
                {
                new Invoice(87, "Electric Sander", 7, 57.98M),
                new Invoice(24, "Power Saw", 18, 99.99M),
                new Invoice(7, "Sledge Hammerr", 11, 21.5M),
                new Invoice(77, "Hammer", 76, 11.99M),
                new Invoice(39, "Lawn Mower", 3, 79.5M),
                new Invoice(68, "Screw Driver", 106, 6.99M),
                new Invoice(56, "Jig Sawr", 21, 11.0M)
            };

            // Display all elements
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Original Invoice array:");
            Console.WriteLine("---------------------------------------");
            foreach (var element in invoice)
            {
                Console.WriteLine(element);
            }

            /*
             * a) Part description of the part who has lowest quantity
             */
            var descriptionLowest =
               from item in invoice
               where item.Quantity == (from x in invoice select x.Quantity).Min()
               select new { item.PartDescription };

            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("Part description of lowest quantity:");
            Console.WriteLine("---------------------------------------");
            foreach (var item in descriptionLowest)
            {
                Console.WriteLine($"{item.PartDescription,-20}");
            }

            /*
             * b) Part description of the part who has highest price
             */
            var descriptionHighest =
               from item in invoice
               where item.Price == (from x in invoice select x.Price).Max()
               select new { item.PartDescription };

            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("Part description of highest price:");
            Console.WriteLine("---------------------------------------");
            foreach (var item in descriptionHighest)
            {
                Console.WriteLine($"{item.PartDescription,-20}");
            }

        } // end Main
    } // end Class
} // end namespace