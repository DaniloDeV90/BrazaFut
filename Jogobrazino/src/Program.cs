
using Jogobrazino.src.Controllers.Cartas;
using Jogobrazino.src.Controllers.Energia;
using Jogobrazino.src.Controllers.Jogador;
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


                jogadores.Add(new Jogadores(nome, new Energia()));

            } while (controller != 2);

            controller = 0;

            Sorteio sorteio = new Sorteio(jogadores);


            List<Jogadores> JogadoresSorteados = new List<Jogadores>
            {
                sorteio.JogadorSorteado(),
                sorteio.JogadorNaosorteado()
            };
            
            Console.WriteLine("Jogador sorteado a começar é: " + JogadoresSorteados[controller].Getnome1());


            string finalizar = "";
            do
            {

                do
                {

                    Console.WriteLine("Jogador " + JogadoresSorteados[controller].Getnome1() + ", Aperte qualquer tecla para gerar as suas 3 cartas");
                    Console.ReadLine();

                    Cartas cartas = new Cartas();

                    JogadoresSorteados[controller].SetCarta(cartas.GerarCartas());
                    JogadoresSorteados[controller].getCarta().ForEach(cartas => Console.WriteLine(cartas.getNome()));
                    Console.ReadLine();

                   
                    Console.Clear();
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