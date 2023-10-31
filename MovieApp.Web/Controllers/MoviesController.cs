using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Controllers
{
    // controller
    public class MoviesController : Controller
    {
        // action
        // localhost:5000/movies/list

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var filmListesi = new List<Movie>()
            {
                new Movie { 
                    Title="film 1",
                    Description="açıklama 1", 
                    Director="Yönetmen 1", 
                    Players=new string[] { "oyuncu 1","oyuncu 2"},
                    ImageUrl="1.jpg"
                },
                new Movie { 
                    Title="film 2",
                    Description="açıklama 1", 
                    Director="Yönetmen 1", 
                    Players=new string[] { "oyuncu 1","oyuncu 2"},
                    ImageUrl="2.jpg"
                },
                new Movie { 
                    Title="film 3",
                    Description="açıklama 1", 
                    Director="Yönetmen 1", 
                    Players=new string[] { "oyuncu 1","oyuncu 2"},
                    ImageUrl="3.jpg"
                }

            };

            var model = new MovieGenreViewModel()
            {
                Movies = filmListesi
            };
            
            return View("Movies", model);
        }

        // localhost:5000/movies/details
        public string Details()
        {
            return "Film Detayı";
        }
    }
}
