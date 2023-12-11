using Jogobrazino.src.Controllers.Jogador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.Penalti
{
    public class DefenderPenalti  : IdefenderPenalti
    {
        public void defender(int controller, List<Ijogador> JogadoresSorteados)
        {
            if (JogadoresSorteados[controller].ladocobrado().getLado().Length > 0)
            {
                int jogadorNaosorteado = controller == 0 ? 1 : 0;



                Console.WriteLine("Escolhe um lado pra defender jogador " + JogadoresSorteados[controller].Getnome());
                Console.WriteLine("0. CENTRO \n 1. ESQUERDA \n 2. DIREITA");

                string ladodefendido = Console.ReadLine();

                int ladoDefendido =   ladodefendido.Length  == 0 ?  0 : int.Parse(ladodefendido);

                string[] lados = { "ESQUERDA", "DIREITA", "CENTRO" };


                

                if (JogadoresSorteados[controller].ladocobrado().getLado() == lados[ladoDefendido])
                {
                    Console.WriteLine("DEFENDEU!!");


                }
                else
                {
                    Console.WriteLine("---------------------");
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("GOOOOOOOOOOOOOOOOOOOOOL");

                    Console.ResetColor();
                    Console.WriteLine(JogadoresSorteados[jogadorNaosorteado].Getnome() + " Converte o penalti!!  ");
                 

                    Console.WriteLine("---------------------");
                    JogadoresSorteados[jogadorNaosorteado].Gol().addGol();
                }
                JogadoresSorteados[controller].ladocobrado().setLado("");
                Console.ReadLine();
            }

        }
    }
    }
