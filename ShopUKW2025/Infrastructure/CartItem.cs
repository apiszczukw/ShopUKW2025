using ShopUKW2025.Models;

namespace ShopUKW2025.Infrastructure
{
    public class CartItem
    {
        public Film Film { get; set; }

        public int Quantity { get; set; }

        public decimal? Value { get; set; }
    }
}