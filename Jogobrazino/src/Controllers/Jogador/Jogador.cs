
using Jogobrazino.src.Controllers.Carta;
using Jogobrazino.src.Controllers.CartaoAmarelo;
using Jogobrazino.src.Controllers.Energia;
using Jogobrazino.src.Controllers.Gols;
using Jogobrazino.src.Controllers.Pontos;
using System.Text;

namespace Jogobrazino.src.Controllers.Jogador
{
    public class Jogadores : Ijogador
    {
        private string nome1;
        private Ienergia energia1;
        private List<ICarta> cartasGeradas;
        private Ipontos pontos;
        private Igol gol;
        private IcartaoAmarelo cartaoAmarelo;
        public Jogadores(string nome, Ienergia energia1, Ipontos pontos, Igol gol, IcartaoAmarelo cartaoAmarelo)
        {
            this.nome1 = nome.Length > 0 ? nome : "maquina";
            this.energia1 = energia1;
            this.pontos = pontos;
            this.gol = gol;
            this.cartaoAmarelo= cartaoAmarelo;
        }

        public string Getnome()
        {

            return nome1;

        }

       
        public Ienergia Energia()
        {
            return energia1;
        }


        public void SetCarta(List<ICarta> cartas)
        {
            this.cartasGeradas = cartas;
        }

        public List<ICarta> getCarta()
        {
            return cartasGeradas;
        }
        public Ipontos Pontos ()
        {
            return pontos;
        }


        public Igol Gol ()
        {
            return gol;
        }
       

        public IcartaoAmarelo CartaoAmarelo ()
        {
            return cartaoAmarelo;
        }


        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.Append(nome1);
            sb.Append("\n");



            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            Jogadores  objJogadores = (Jogadores)obj;

            if (objJogadores == null) return false;
            return   nome1 == objJogadores.Getnome ();
        }
    }

}
