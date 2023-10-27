using Jogobrazino.src.interfaces;


namespace Jogobrazino.src.Controllers.Sorteio
{
    public class Sorteio : Isorteio
    {

  

        public String CaraOuCoroa()
        {

            string[] caraOucoroa = { "Cara", "Coroa" };


            Random random = new Random();


            int indice = random.Next(1);

            return caraOucoroa[indice];


        }
    }
}
