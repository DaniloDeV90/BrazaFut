using Jogobrazino.src.Controllers.Jogador;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Jogobrazino.src.Controllers.Penalti
{
    public class Penalti : Ipenalti
    {

        public void CobrarPenalti(Ijogador cobrador)
        {
            string[] lados = { "ESQUERDA", "DIREITA", "CENTRO" };
            try
            {


       

                Random random = new Random();

                Console.WriteLine("0. CENTRO \n 1. ESQUERDA \n 2. DIREITA");

                int lado = int.Parse(Console.ReadLine());


                cobrador.ladocobrado().setLado(lados[lado]);

            }
            catch (FormatException)
            {
                cobrador.ladocobrado().setLado(lados[2]);
            }
        }
    }
}
