using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorbisHotDog.Model
{
    public class CartItem
    {
        public HotDog HotDog { get; set; }
        public int Amount { get; set; }
    }
}
