using Jogobrazino.src.Controllers.Carta;
using Jogobrazino.src.Controllers.Jogador;
using Jogobrazino.src.Controllers.Penalti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Jogobrazino.src.Controllers.Acoes
{
    public class AcoesDoJogo
    {

        public Ipenalti penalti = new Penalti.Penalti();


        public bool CartasIguais(List<ICarta> cartas)
        {

            
            ICarta carta = cartas[0];

            for (int i = 0; i < 3; i++)
            {

                if (carta.getNome() != cartas[i].getNome()) return false;
            }

            return true;
        }

        public void GerarAcao (Ijogador jogador, Ijogador jogado2)
        {

            switch (jogador.getCarta()[0].getNome())
            {

                case "GOL":



                    Console.WriteLine("---------------------");
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("GOOOOOOOOOOOOOOOOOOOOOL");

                    Console.ResetColor();
                    Console.WriteLine(jogador.Getnome() + " Foge da marcação e marca um golaço!");
                    jogador.Gol().addGol();

                    Console.WriteLine("---------------------");
                    break;



                case "PÊNALTI":
                    Console.WriteLine("---------------------");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("PEEENAAALIDADE MAXIMA");

                    Console.ResetColor();
                    Console.WriteLine(" O jogador " + jogador.Getnome() + " irá cobrar um penâlti");
                    
                    Console.ReadLine();
                    Console.WriteLine("Digite o lado em que você irá chutar a bola, opcoes: ESQUERDA, DIREITA, CENTRO");

                   penalti.CobrarPenalti(jogado2);


                    Console.WriteLine("---------------------");
                    break;

                case "FALTA":


                    Console.WriteLine("FALTA MARCADA,  JOGADOR " + jogador.Getnome() + " PASSOU A  VEZ!");


                    break;

                case "CARTÃO VERMELHO":
                    Console.WriteLine("JOGADOR " + jogador.Getnome() + " TOMOU CARTÃO VERMELHO E PERDEU 2 ENERGIAS");
                    jogador.Energia ().removeEnergia (2);


                    break;

                case "CARTÃO AMARELO":
                    if (jogador.CartaoAmarelo().getCartaoAmarelo() >= 2)
                    {
                        Console.WriteLine("JOGADOR " + jogador.Getnome() + " TOMOU O SEGUNDO CARTÃO AMARELO E PERDEU 2 ENERGIA");
                        jogador.Energia().removeEnergia (2);
                    }
                    else
                    {
                        Console.WriteLine("JOGADOR " + jogador.Getnome() + " TOMOU CARTÃO AMARELO E PERDEU 1 ENERGIA, NA PRÓXIMA PERDERÁ 2 ENERGIAS");
                        jogador.Energia ().removeEnergia (1);
                    }


                    break;


                case "ENERGIA":

                    Console.WriteLine("Jogador " + jogador.Getnome() + " Recebeu 1 energia!");
                    jogador.Energia().addEnergia();
                    break;

            }



        }
    }
}
