using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComicBookGallery3.Models;
using ComicBookGallery3.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ComicBookGallery3.Controllers
{
    public class ComicBooksController : Controller
    {

        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
        // GET: /<controller>/
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

                var comicBook = _comicBookRepository.GetComicBook((int)id);
            

            return View(comicBook);
        }
    }
}
