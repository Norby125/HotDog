using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorbisHotDog.Model;

namespace NorbisHotDog.Repository
{
    public class CartRepository
    {
        static Cart MainCart = new Cart() { CartItems = new List<CartItem>() };

        public void AddCartItem(HotDog hotDog, int amount)
        {
            var cartItem = new CartItem() {HotDog = hotDog, Amount = amount};
            if (!MainCart.CartItems.Contains(cartItem))
            {
                MainCart.CartItems.Add(cartItem);
            }
            else
            {
                //TODO
            }

            
        }

        public Cart GetCart()
        {
            return MainCart;
        }
    }
}
