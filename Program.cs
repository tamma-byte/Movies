using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesPractice_GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            //GETTERS AND SETTERS help make classes more SECURE
            Movie avengers = new Movie("Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            //EXERCISE: Ratings can only be G, PG, PG-13, R, NR
            //Because Ratings is Private

            Console.WriteLine(shrek.Rating);

            Console.ReadLine();
        }
    }
}
