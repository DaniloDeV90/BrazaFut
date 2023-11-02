using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.Carta
{
    public class Carta : ICarta
    {
        private String nome;
        private int pontos;

        public Carta(string nome, int pontos)
        {
            this.nome = nome;
            this.pontos = pontos;
        }


        public String getNome()
        {
            return nome;
        }

        public  int  getPontos ()
        {
            return pontos;
        }
    }
}
