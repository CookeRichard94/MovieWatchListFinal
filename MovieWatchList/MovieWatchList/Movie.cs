using System;
using System.Collections.Generic;
using System.Text;

namespace MovieWatchList
{
    class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Year { get; set; }
        public string RunTime { get; set; }
        public string Country { get; set; }
        public string IMDBRating { get; set; }
        public string Starring { get; set; }
        public string Director { get; set; }
        public string BoxOffice { get; set; }

        //Constructors
        public Movie()
        {

        }

        public Movie(string t, string y, string d, string rt, string c, string ir, string s, string dir, string b)
        {
            Title = t;
            Description = d;
            Year = y;
            RunTime = rt;
            Country = c;
            IMDBRating = ir;
            Starring = s;
            Director = dir;
            BoxOffice = b;
        }
    }
}
