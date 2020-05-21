using System;

namespace LearningCSharp
{
    class Film
    {
        // Instance variables
        public string title;
        public string director;
        // "private" means only code in this "film" class can set this property
        private string rating;

        public Film(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;       // See "Rating" property below
        }

        // NB. Access to private <rating> class field is get and set by
        //     the public property: "Rating".
        public string Rating
        {
            get { return rating; }

            // Ensure set rating is valid, else return default "NR" (not rated)
            // Keyword "value" is used to hold the passed in set value.
            set
            {
                if (value == "U" || value == "PG" || value == "12A"
                    || value == "12" || value == "15" || value == "18")
                {
                    rating = value;
                } else
                {
                    rating = "NR";
                }
            }
        }
    }
}
