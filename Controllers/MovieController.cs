using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab21.Repositories;
using Lab21.Models;

namespace Lab21.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRep _repo;
        public MovieController(IMovieRep repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
           
            return View();
        }

        // GET: MovieController/Sear
        public IActionResult SearchResultGenre(MovieSearchViewModel model)
        {
            var list = _repo.Get().Where(x => x.Genre == model.Genre);
                return View(list);
        }
        // GET: MovieController/Details/5
        public IActionResult SearchResultTitle(MovieSearchViewModel model)
        {
            var list = _repo.Get().Where(x => x.MovieName.Contains(model.MovieName));
                return View(list);
        }

    }
}
