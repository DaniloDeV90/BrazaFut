using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.Pontos
{
    public class Ponto : Ipontos
    {
        private int Pontos = 0;

        public void addPontos(int Pontos)
        {
            this.Pontos += Pontos;
        }

        public int getPontos()
        {
            return this.Pontos;
        }

        public void  removePontos(int Pontos)
        {
            this.Pontos  -= Pontos;
        }
    }
}
