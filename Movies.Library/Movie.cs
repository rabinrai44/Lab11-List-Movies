using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Library
{
    public class Movie
    {
        //Properties
        private string Title { get; set; }
        private string Category { get; set; }

        //accessing properties with public movie constructor
        //movie constructor 
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }

        public string GetTitle()
        {
            return Title;
        }

        public string GetCategory()
        {
            return Category;
        }
        
    }
}
