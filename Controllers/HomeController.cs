using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaMattersCCV2.Models;
using MediaMattersCCV2.Models.album;
using MediaMattersCCV2.Models.book;
using MediaMattersCCV2.Models.game;
using Microsoft.AspNetCore.Mvc;


namespace MediaMattersCCV2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBook br;
        private readonly IAlbum ar;
        private readonly IGame gr;

        public HomeController(IBook BookR, IAlbum AlbumR, IGame GameR)
        {
            br = BookR;
            ar = AlbumR;
            gr = GameR;

        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Album()
        {
            return View(ar.getAlbums());
        }
        public IActionResult Book()
        {
            return View(br.getBooks());
        }
        public IActionResult Game()
        {
            return View(gr.getGames());
        }
    }
}
