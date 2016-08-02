using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorbisHotDog.Model;
using NorbisHotDog.Repository;

namespace NorbisHotDog.Service
{
    public class CartDataService
    {
        private static CartRepository cartRepository = new CartRepository();
        public void AddCartItem(HotDog hotDog, int amount)
        {
            cartRepository.AddCartItem(hotDog, amount);
        }

        public Cart GetCart()
        {
            return cartRepository.GetCart();
        }
    }
}
