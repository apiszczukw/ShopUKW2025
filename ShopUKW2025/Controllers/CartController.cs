using Microsoft.AspNetCore.Mvc;
using ShopUKW2025.DAL;
using ShopUKW2025.Infrastructure;
using ShopUKW2025.Models;

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

        public IActionResult RemoveFromCart(int id)
        {
            var model = new RemoveViewModel()
            {
                itemQuantity = CartManager.RemoveFromCart(HttpContext.Session, id),
                itemId = id,
                cartValue = CartManager.GetCartValue(HttpContext.Session)
            };

            return Json(model);
        }
    }
}
