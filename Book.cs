using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
        private string rating;

        public Book(string aTitle, string aAuthor, int aPages, string aRating)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            Rating = aRating;

        }

        //getters and setters for private properties
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

        public bool IsChunky()
        {
            if (pages >= 500)
            {
                return true;
            }

            return false;
        }
    }

}