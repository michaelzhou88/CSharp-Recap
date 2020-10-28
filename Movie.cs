using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Giraffe
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;  // MORE SECURE to use private modifier to prevent user enter an invalid rating

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            rating = aRating;
        }

        // GETTERS AND SETTERS
        // Naming convention is take the same private variable name but in capitals for the first letter
        public string Rating
        {
            // GETTER - Allows us to GET the rating
            get { return rating; }
            // SETTER - Allows us to SET the rating
            set
            {
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
