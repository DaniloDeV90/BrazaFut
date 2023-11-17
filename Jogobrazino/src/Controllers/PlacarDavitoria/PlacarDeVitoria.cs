using Jogobrazino.src.Controllers.Jogador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.PlacarDavitoria
{
    internal class PlacarDeVitoria
    {
        public void Vitoria(Ijogador vitorioso, Ijogador perdedor)
        {

            Console.WriteLine("PARABENS  " + vitorioso.Getnome() + "\n");
            Console.WriteLine ( "VOCÊ VENCEU COM  " +  vitorioso.Gol ().getGol ()  + " GOLS E  " +  vitorioso.Pontos ().getPontos ( ) + "  PONTOS\n");
          Console.WriteLine  (   "O SEU ADVERSÁRIO FEZ  " + perdedor.Gol().getGol() +" GOLS E  " + perdedor.Pontos ().getPontos () + "  PONTOS\n ");
        }
    }
}
