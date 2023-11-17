using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.Energia
{
    public class Energia : Ienergia
    {


        private int energia = 10;
       
        public void addEnergia()
        {
            energia++;
        }
        public void removeEnergia(int valor)
        {

            energia -= valor;
        }


        public  int getEnergia ()
        {
            return energia;
        }

    }
}
