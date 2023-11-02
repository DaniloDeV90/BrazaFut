
using Jogobrazino.src.Controllers.Carta;
using Jogobrazino.src.Controllers.Energia;
using System.Text;

namespace Jogobrazino.src.Controllers.Jogador
{
    public class Jogadores : Ijogador
    {
        private string nome1;
        private Ienergia energia1;
        private List<ICarta> cartasGeradas;



        public Jogadores(string nome, Ienergia energia1)
        {
            this.nome1 = nome.Length > 0 ? nome : "maquina";
            this.energia1 = energia1;

        }


        public string Getnome1()
        {

            return nome1;

        }


        public Ienergia GetEnergia1()
        {
            return energia1;
        }


        public void SetCarta(List<ICarta> cartas)
        {
            this.cartasGeradas = cartas;
        }

        public List<ICarta> getCarta( )
        {
            return cartasGeradas;
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
            return   nome1 == objJogadores.Getnome1 ();
        }
    }

}
