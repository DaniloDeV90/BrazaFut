using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.Pontos
{
    public  interface Ipontos
    {
        public void addPontos(int Pontos);
      

        public int getPontos();
        public void removePontos(int Pontos);
    }
}
