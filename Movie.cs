using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesPractice_GettersSetters
{
    class Movie
    {
        public string name;
        public string director;
        private string rating;
        //SET Rating as private so only certain values can be shown
        //Ratings can only be G, PG, PG-13, R, NR
        //Hence we need Getters and Setters TO BE SECURE

        public Movie(string cName, string cDirector, string cRating)
        {
            name = cName;
            director = cDirector;
            Rating = cRating;
        }

        public string Rating
        {
            get { return rating; }
            set { 
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }

    }
}
