using Jogobrazino.src.Controllers.Jogador;
using Jogobrazino.src.Controllers.PlacarDavitoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.Vencedor
{
    public  class ResultadoFinal
    {

    
        public   int   GerarResultadoFinal(List<Ijogador> jogadores)
        {
           PlacarDeVitoria placarDevitoria  =   new PlacarDeVitoria();


            var jogador  =    jogadores.Where(n =>  n.Energia().getEnergia() > 0 ) ;
         
            if (jogador.Count  () > 0) return 1 ;




         if (jogadores[0].Gol ().getGol () > jogadores[1].Gol().getGol())
            {

                Console.ReadLine();
                placarDevitoria.Vitoria(jogadores[0], jogadores[1]);
                Console.WriteLine("Jogador " + jogadores[0].Getnome() + " Venceu a partida!");

                return 0;
            }
            if (jogadores[1].Gol().getGol() > jogadores[0].Gol().getGol())
            {
                Console.ReadLine();
                placarDevitoria.Vitoria(jogadores[1], jogadores[0]);
                Console.WriteLine("Jogador " + jogadores[1].Getnome() + " Venceu a partida!");
                return 0;
            }
            else
            {
                if (jogadores[0].Pontos().getPontos() > jogadores[1].Pontos().getPontos())
                {
                    Console.ReadLine();
                    Console.WriteLine("Jogador" + jogadores[0].Getnome() + " Venceu a partida pelo o número de Pontos!!!!\n");
                    placarDevitoria.Vitoria(jogadores[0], jogadores[1]);
                    return 0;
                }

                if (jogadores[1].Pontos().getPontos() > jogadores[0].Pontos().getPontos())
                {
                    Console.ReadLine();
                    Console.WriteLine("Jogador" + jogadores[1].Getnome() + " Venceu a partida pelo o número de Pontos!!!!\n");
                    placarDevitoria.Vitoria(jogadores[1], jogadores[9]);
                    return 0;
                }
                else
                {
                    Console.WriteLine("Empate!!");
                    return 0;
                }
            }



        }
    }
}
