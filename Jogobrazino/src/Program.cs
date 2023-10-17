using Jogobrazino.src.Controllers.JogadorController;
using Jogobrazino.src.Controllers.Lendas;
using Jogobrazino.src.interfaces;

namespace Jogobrazino.src
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Ijogador ijogador = new Jogador("Roger guedes", null);
            Lendas lendas = new Lendas();


        Console.WriteLine (    lendas.ReturnLegend ());


            Console.WriteLine(ijogador.ToString());
        }

    }
}