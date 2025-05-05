using ShopUKW2025.DAL;

namespace ShopUKW2025.Infrastructure
{
    public static class CartManager
    {

        public static List<CartItem> GetItems(ISession session)
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(session, Keys.CartSessionKey);

            if (cart == null)
            {
                cart = new List<CartItem>();
            }

            return cart;
        }

        public static void AddToCart(ISession session, FilmsContext db, int filmId)
        {
            var cart = GetItems(session);
            var thisFilm = cart.Find(f => f.Film.FilmId == filmId);

            if (thisFilm != null)
            {
                thisFilm.Quantity++;
            }
            else
            {
                var newCartItem = db.Films.Find(filmId);

                if (newCartItem != null)
                {
                    var cartItem = new CartItem()
                    {
                        Film = newCartItem,
                        Quantity = 1,
                        Value = newCartItem.Price
                    };

                    cart.Add(cartItem);
                }
            }

            SessionHelper.SetObjectAsJson(session, Keys.CartSessionKey, cart);
        }

        public static decimal? GetCartValue(ISession session)
        {
            var cart = GetItems(session);

            return cart.Sum(c => c.Value * c.Quantity);
        }
    }
}
