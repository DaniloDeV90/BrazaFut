using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.Lendas
{
    internal class Lendas

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
        public int ReturnLegend()
        {

            Random random = new Random();

            return random.Next(lendas.Count);


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