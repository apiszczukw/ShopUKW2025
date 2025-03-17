using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopUKW2025.DAL;
using ShopUKW2025.Migrations;

namespace ShopUKW2025.Controllers
{
    public class FilmsController : Controller
    {
        FilmsContext db;

		public FilmsController(FilmsContext db)
		{
			this.db = db;
		}

		public IActionResult ProductList(string categoryName)
        {
            var category = db.Categories.Include("Films").Where(c => c.Name == categoryName).Single();

            var films = category.Films.ToList();

            return View(films);
        }
    }
}
