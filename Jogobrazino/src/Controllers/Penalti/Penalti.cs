using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.Penalti
{
    public class Penalti : Ipenalti
    {

        public bool CobrarPenalti()
        {

            try
            {


                string[] lados = { "ESQUERDA", "DIREITA", "CENTRO" };

                Random random = new Random();
                Console.WriteLine("0. CENTRO \n 1. ESQUERDA \n 2. DIREITA");

                int lado = int.Parse(Console.ReadLine());

                if (lado > 3 || lado < 0) return false;
                int indiceLado = random.Next(lados.Length);
                Console.WriteLine(indiceLado);
                string ladoDoGoleiro = lados[indiceLado];
                if (ladoDoGoleiro != lados[lado]) return true;
                return false;

            } catch (FormatException)
            {
  
                return false;
            }
        }
    }
}

