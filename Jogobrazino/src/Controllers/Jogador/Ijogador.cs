using Jogobrazino.src.Controllers.Carta;
using Jogobrazino.src.Controllers.CartaoAmarelo;
using Jogobrazino.src.Controllers.Energia;
using Jogobrazino.src.Controllers.Gols;
using Jogobrazino.src.Controllers.Pontos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.Jogador
{
    public interface Ijogador
    {
        public string Getnome();



        public Ienergia Energia();

        public void SetCarta(List<ICarta> cartas);


        public List<ICarta> getCarta();

        public Ipontos Pontos();

    
        public IcartaoAmarelo CartaoAmarelo();
        public Igol Gol();
    
    }
}
