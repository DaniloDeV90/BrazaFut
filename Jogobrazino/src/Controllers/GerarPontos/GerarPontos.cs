using Jogobrazino.src.Controllers.Carta;
using Jogobrazino.src.Controllers.Jogador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.GerarPontos
{
    public class GerarPontos : IgerarPontos
    {

        public void PontosDeCarta(Ijogador jogadores)
        {

            List<ICarta> cartas = jogadores.getCarta();

            cartas.ForEach(c =>   jogadores.Pontos ().addPontos(c.getPontos()));


        }
    }
}
