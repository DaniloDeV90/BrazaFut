

using Jogobrazino.src.Controllers.LendasController;
using Jogobrazino.src.interfaces;

namespace Jogobrazino.src.Controllers.JogadorController
{
    public class Jogador : Ijogador
    {
        private string jogador1 { get; }
        private string jogador2 { get;  }


        private Ilendas lendas { get; set; }
       
 
        public Jogador(string jogador1, string jogador2, Ilendas lendas)
        {
            this.jogador1 = jogador1;
            this.lendas = lendas;
            if (string.IsNullOrEmpty(jogador2)) this.jogador2 = lendas.ReturnLegend ();
             else  this.jogador2 = jogador2;
        }


        public  string _jogador1 ()
        {
            return jogador1;
        }

        public string _jogador2 ()
        {
            return jogador2;
        }
        public override string ToString()
        {
            return jogador1 + " X " + jogador2;
        }
    }
}
