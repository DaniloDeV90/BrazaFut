using Jogobrazino.src.Controllers.Carta;
using Jogobrazino.src.Controllers.Energia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.Jogador
{
    public interface Ijogador
    {
        public string Getnome1();



        public Ienergia GetEnergia1();

        public void SetCarta(List<ICarta> cartas);


        public List<ICarta> getCarta();



    }
}
