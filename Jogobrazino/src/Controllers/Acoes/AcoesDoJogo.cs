using Jogobrazino.src.Controllers.Carta;
using Jogobrazino.src.Controllers.Jogador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.Acoes
{
    public class AcoesDoJogo
    {

        public bool CartasIguais(List<ICarta> cartas)
        {

            ICarta carta = cartas[0];

            for (int i = 0; i < 3; i++)
            {

                if (carta.getNome() != cartas[i].getNome()) return false;
            }

            return true;
        }

        public void GerarAcao (Ijogador jogador)
        {

            switch (jogador.getCarta()[0].getNome())
            {

                case "GOL":



                    Console.WriteLine("---------------------");
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("GOOOOOOOOOOOOOOOOOOOOOL");
                    
                    Console.ResetColor();
                    Console.WriteLine(jogador.Getnome ()  +  " Foge da marcação e marca um golaço!" );
                    jogador.Gol().addGol();

                    Console.WriteLine("---------------------");
                    break;
            }



        }
    }
}
