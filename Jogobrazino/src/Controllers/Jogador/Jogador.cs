using Jogobrazino.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.JogadorController
{
    public class Jogador : Ijogador
    {
        private string jogador1 { get; set; }
        private string jogador2 { get; set; }

        public Jogador(string jogador1, string jogador2)
        {
            this.jogador1 = jogador1;

            string _jogador2 = jogador2 ?? "maradona";

            this.jogador2 = _jogador2;
        }


        public string _jogador1()
        {

            return jogador1;
        }

        public string _jogador2()
        {



            return jogador2;
        }

        public override string ToString()
        {
            return jogador1 + " X " + jogador2;
        }
    }
}
