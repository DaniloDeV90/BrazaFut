

using Jogobrazino.src.interfaces;

namespace Jogobrazino.src.Controllers.LendasController
{
    public class Lendas : Ilendas

    {

        private List<string> lendas = new List<string>();


        public Lendas()
        {
            lendas.Add("Zidane");
            lendas.Add ("Pelé" );
            lendas.Add("Messi");
            lendas.Add("Iniesta");
            lendas.Add("Cristiano Ronaldo");
            lendas.Add("Johan Cruijff");
            lendas.Add("Beckenbauer");
            lendas.Add("Ronaldinho gaúcho");
            lendas.Add("Ronaldo Fenômeno");
            lendas.Add("Romário");

        }

        public void addLegends(string legend)
        {

            lendas.Add(legend);
        }
        public string ReturnLegend()
        {

            Random random = new Random();

            return lendas[random.Next (lendas.Count)];


        }


        public void MostrarArr()
        {
            for (int i = 0; i < lendas.Count; i++)
            {

                Console.WriteLine(lendas[i]);

            }


        }

    }
}