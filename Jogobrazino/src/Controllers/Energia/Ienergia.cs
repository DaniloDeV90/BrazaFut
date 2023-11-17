using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.Energia
{
    public interface Ienergia
    {


        public void addEnergia();

        public void removeEnergia(int valor);

        public int getEnergia();
      
    }
}
