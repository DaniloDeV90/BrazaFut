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
            cartas.Add(new Carta.Carta("GOL", 3));
            cartas.Add(new Carta.Carta("PÊNALTI", 2));
            cartas.Add(new Carta.Carta("FALTA", 1));
            cartas.Add(new Carta.Carta("CARTÃO AMARELO", 1));
            cartas.Add(new Carta.Carta("CARTÃO VERMELHO", 0));
            cartas.Add(new Carta.Carta("ENERGIA", 2));

        }


        public List<ICarta> GerarCartas()
        {
            List<ICarta> cartasGeradas = new List<ICarta>();
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
     
                if (random.Next(100) < 75 && cartasGeradas.Count > 0)
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
