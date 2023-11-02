using Jogobrazino.src.Controllers.Carta;
using Jogobrazino.src.Controllers.Jogador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.Cartas
{
    public class Cartas
    {

        private List<ICarta> cartas = new List<ICarta>();

        public Cartas()
        {
            cartas.Add(new Carta.Carta("Gol", 3));
            cartas.Add(new Carta.Carta("Pênalti", 2));
            cartas.Add(new Carta.Carta("Falta", 1));
            cartas.Add(new Carta.Carta("Cartão Amarelo", 1));
            cartas.Add(new Carta.Carta("Cartão Vermelho", 0));
            cartas.Add(new Carta.Carta("Energia", 2));

        }


        public List<ICarta> GerarCartas()
        {
            List<ICarta> cartasGeradas = new List<ICarta>();
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
            
                if (random.Next(100) < 60 && cartasGeradas.Count > 0)
                {
                    int indiceExistente = random.Next(cartasGeradas.Count);
                    cartasGeradas.Add(cartasGeradas[indiceExistente]);
                }
                else
                {
                    int indice = random.Next(cartas.Count);
                    cartasGeradas.Add(cartas[indice]);
                }
            }

            return cartasGeradas;
        }


      
    }

    
}
