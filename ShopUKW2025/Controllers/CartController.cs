using Microsoft.AspNetCore.Mvc;
using ShopUKW2025.DAL;
using ShopUKW2025.Infrastructure;

namespace ShopUKW2025.Controllers
{
    public class CartController : Controller
    {
        FilmsContext db;

        public CartController(FilmsContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var cart = CartManager.GetItems(HttpContext.Session);

            ViewBag.Total = CartManager.GetCartValue(HttpContext.Session);

            return View(cart);
        }

        public IActionResult AddToCart(int filmId)
        {
            CartManager.AddToCart(HttpContext.Session, db, filmId);

            return RedirectToAction("Index");
        }
    }
}
