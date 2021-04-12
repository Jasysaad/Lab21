using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab21.Models
{
    //create a list of 15 movies
    public class MovieModel

    {
        public MovieModel(string name, Genre genre)
        {
            MovieName = name;
            Genre = genre;
        }
        
        public string MovieName { get; set; }
        public Genre Genre { get; set; }

    }
}
