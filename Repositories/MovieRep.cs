using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab21.Models;

namespace Lab21.Repositories
{
    //create a list of 15 movies
    public class MovieRep : IMovieRep
    {
        private readonly List<MovieModel> _movie = new List<MovieModel>();

        public List<MovieModel> Get()
        {
            var _movie = new List<MovieModel>();
            _movie.Add(new MovieModel("Mummy", Genre.SciFi));
            _movie.Add(new MovieModel("27 Dresses", Genre.Drama));
            _movie.Add(new MovieModel("The Nun", Genre.Horror));
            _movie.Add(new MovieModel("Martian", Genre.SciFi));
            _movie.Add(new MovieModel("Alien", Genre.Action));
            _movie.Add(new MovieModel("The Road", Genre.SciFi));
            _movie.Add(new MovieModel("Borat", Genre.Comedy));
            _movie.Add(new MovieModel("How to Lose a Guy in 10 Days", Genre.Drama));
            _movie.Add(new MovieModel("The Vow", Genre.Drama));
            _movie.Add(new MovieModel("RAMBO: First Blood", Genre.Action));
            _movie.Add(new MovieModel("The Expendables", Genre.Action));
            _movie.Add(new MovieModel("Failure to Launch", Genre.Drama));
            _movie.Add(new MovieModel("Meet the Fockers", Genre.Comedy));
            _movie.Add(new MovieModel("Nacho Libre", Genre.Comedy));
            _movie.Add(new MovieModel("Evil Dead", Genre.Horror));
            _movie.Add(new MovieModel("The Hangover", Genre.Comedy));
            _movie.Add(new MovieModel("uperbad", Genre.Comedy));
            _movie.Add(new MovieModel("Pineapple Express", Genre.Comedy));
            return _movie;
        }
       
        
    }
}
