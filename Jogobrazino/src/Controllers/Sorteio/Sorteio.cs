using Jogobrazino.src.Controllers.Jogador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.Sorteio
{
    public class Sorteio
    {
        private List<Jogadores> jogadores;
        private Jogadores jogadorInicial;
        private Jogadores Jogador2;

        public Sorteio( List <Jogadores> jogadores)
        {
            this.jogadores = jogadores;

            Random random = new Random();

            int numero = random.Next(2);


            if (jogadores[numero].Equals(jogadores[1]))
            {
                jogadorInicial = jogadores[1];
                Jogador2 = jogadores[0];
            }
            else
            {
                jogadorInicial = jogadores[0];
                Jogador2 = jogadores[1];
            }
        }




        public Jogadores JogadorSorteado()
        {
            return jogadorInicial;
        }

        public Jogadores JogadorNaosorteado()
        {
            return  Jogador2;
        }
    }
}
