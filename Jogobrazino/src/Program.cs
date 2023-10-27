using Jogobrazino.src.Controllers.Energia;
using Jogobrazino.src.Controllers.JogadorController;
using Jogobrazino.src.Controllers.LendasController;
using Jogobrazino.src.Controllers.Sorteio;
using Jogobrazino.src.interfaces;
using System.Text;

namespace Jogobrazino.src
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Digite o nome do jogador 1");
            string jogador1 = Console.ReadLine();
            Console.WriteLine("Digite o nome do jogador 2 ou aperte Enter para jogar contra a máquina");

            string jogador2 = Console.ReadLine();

            Ilendas ilendas = new Lendas();

            Ijogador ijogador = new Jogador(jogador1, jogador2, ilendas);


            Ienergia energiaJogador1 = new Energia(ijogador._jogador1(), 10);

            Ienergia energiaJogador2 = new Energia(ijogador._jogador2(), 10);


            Isorteio sorteio = new Sorteio();

            string[] moedas = { "cara", "coroa" };

            Console.WriteLine("Jogador: " + energiaJogador1._jogador() + "  Digite cara ou coroa: ");
            String valor1 = Console.ReadLine();


    

            if(!moedas.Contains (valor1))
            {

                throw new Exception();
            }


            Console.WriteLine("Jogador: " + energiaJogador2._jogador() + " Digite cara ou coroa: ");
            String valor2 = Console.ReadLine();


            if (!moedas.Contains(valor2))
            {

                throw new Exception();
            }

       

            string resultado =  sorteio.CaraOuCoroa();





            Console.WriteLine(energiaJogador1 + "\n" + energiaJogador2);
            Console.ReadLine();

        }

    }
}