using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using ShopUKW2025.DAL;
using ShopUKW2025.Migrations;
using ShopUKW2025.Models;

namespace ShopUKW2025.Controllers
{
    public class FilmsController : Controller
    {
        FilmsContext db;
        IWebHostEnvironment webHost;

        public FilmsController(FilmsContext db, IWebHostEnvironment webHost)
        {
            this.db = db;
            this.webHost = webHost;
        }

        [HttpGet]
        public IActionResult AddFilm()
        {
            var model = new AddFilmViewModel();
            model.AllCategories = db.Categories.ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult AddFilm(AddFilmViewModel model)
        {
           

            var picFolderPath = Path.Combine(webHost.WebRootPath, "obrazki");

            var uniqueName = Guid.NewGuid() + "_" + model.Poster.FileName;

            var filePath = Path.Combine(picFolderPath, uniqueName);

            model.Poster.CopyTo(new FileStream(filePath, FileMode.Create));

            model.NewFilm.Poster = uniqueName;

            db.Films.Add(model.NewFilm);
            db.SaveChanges();

            return RedirectToAction("Details", new { filmId = model.NewFilm.FilmId });
        }


        public IActionResult AllFilms()
        {

            return View(db.Films.ToList());
        }

		public IActionResult ProductList(string categoryName)
        {
            var category = db.Categories.Include("Films").Where(c => c.Name == categoryName).Single();

            var films = category.Films.ToList();

            return View(films);
        }

        public IActionResult Details(int filmId)
        {
            db.Categories.Find(db.Films.Find(filmId).CategoryId);

            var film = db.Films.Find(filmId);

            return View(film);
        }
    }
}
