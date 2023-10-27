using Jogobrazino.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.Energia
{

    public class Energia : Ienergia
    {

        private string jogador;
        private int energia;

        public Energia(string jogador, int energia)
        {
            this.jogador = jogador;
            this.energia = energia;
        }


        public string _jogador()
        {
            return this.jogador;
        }

        public int _energia()
        {
            return this.energia;
        }



        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("Jogador: " + this.jogador + "\n");
            stringBuilder.AppendLine("Energia: " + this.energia + "\n");
            return stringBuilder.ToString();
        }
    }
}
