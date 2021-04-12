using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab21.Models;

namespace Lab21.Repositories
{
   public interface IMovieRep
    {
        //create a list of 15 movies, using a GET to call the movies 
        List<MovieModel> Get();
 
    }
}
