using Jogobrazino.src.Controllers.Jogador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.Penalti
{
    public interface IdefenderPenalti
    {
        public void defender(int controller, List<Ijogador> JogadoresSorteados);



    }
}

