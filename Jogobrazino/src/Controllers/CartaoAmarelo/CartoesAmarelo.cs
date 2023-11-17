using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.CartaoAmarelo
{
     public  class CartaoAmarelo : IcartaoAmarelo
    {
        private  int cartoesAmarelos = 0;
        public void addCartaoAmarelo()
        {
            cartoesAmarelos++;
        }
        public int getCartaoAmarelo()
        {
            return cartoesAmarelos;
        }
    }
}
