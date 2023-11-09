
using Jogobrazino.src.Controllers.Acoes;
using Jogobrazino.src.Controllers.Cartas;
using Jogobrazino.src.Controllers.Energia;
using Jogobrazino.src.Controllers.GerarPlacar;
using Jogobrazino.src.Controllers.Gols;
using Jogobrazino.src.Controllers.Jogador;
using Jogobrazino.src.Controllers.Pontos;
using Jogobrazino.src.Controllers.Sorteio;
using System;
using System.Text;

namespace Jogobrazino.src
{
    public class Program
    {

        public static void Main(string[] args)
        {

            List<Jogadores> jogadores = new List<Jogadores>();


            int controller = 0;
            do
            {
                controller++;
                Console.WriteLine("Digite o nome do jogador " + controller);
                string? nome = Console.ReadLine();

                if (controller == 1 && nome.Length == 0) { Console.WriteLine("O primeiro jogaodr não pode ser nulo!"); return; }


                jogadores.Add(new Jogadores(nome, new Energia(),  new Ponto ( ), new Gol () ));

            } while (controller != 2);

            controller = 0;

            Sorteio sorteio = new Sorteio(jogadores);


            List<Jogadores> JogadoresSorteados = new List<Jogadores>
            {
                sorteio.JogadorSorteado(),
                sorteio.JogadorNaosorteado()
            };
            
            Console.WriteLine("Jogador sorteado a começar é: " + JogadoresSorteados[controller].Getnome());


            string finalizar = "";
            do
            {

                do
                {

                    if (JogadoresSorteados[controller].Energia().getEnergia() > 0)
                    {
                        Console.WriteLine("Jogador " + JogadoresSorteados[controller].Getnome() + ", Aperte qualquer tecla para gerar as suas 3 cartas");
                        Console.ReadLine();

                        Cartas cartas = new Cartas();

                        Console.Clear();
                        Console.WriteLine("-------------" + "\n" +
                        "Cartas geradas ");


                        JogadoresSorteados[controller].SetCarta(cartas.GerarCartas());
                        JogadoresSorteados[controller].getCarta().ForEach(cartas => Console.WriteLine(cartas.getNome()));
                        Console.ReadLine();

                        AcoesDoJogo acoesDoJogo = new AcoesDoJogo();

                        Console.WriteLine((acoesDoJogo.CartasIguais(JogadoresSorteados[controller].getCarta())));
                        if (acoesDoJogo.CartasIguais(JogadoresSorteados[controller].getCarta()))
                        {
                            acoesDoJogo.GerarAcao(JogadoresSorteados[controller]);

                        }

                        Console.ReadLine();


                        Console.Clear();


                        new GerarPlacar().Placar(JogadoresSorteados);

                    }
                    else
                    {
                        Console.WriteLine("Sem energia! passou a vez");
                    }
               
                    controller++;
                } while (controller != 2);



                Console.WriteLine("Para finalizar aperte 1 ou qualquer outra tecla para continuar");
                controller = 0;
                finalizar = Console.ReadLine();
            } while (finalizar.Equals ("") );

            Console.ReadLine();

        }

    }
}