using Jogobrazino.src.Controllers.Jogador;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Jogobrazino.src.Controllers.GerarPlacar
{
    public class GerarPlacar
    {
        public void Placar(List<Ijogador> Jogadores)
        {
            StringBuilder stringBuilder = new StringBuilder();


            stringBuilder.Append("--------------PLACAR---------------");
            stringBuilder.Append("\n");
            stringBuilder.Append(Jogadores[0].Getnome() + " ");
            stringBuilder.Append(Jogadores[0].Gol().getGol());
            stringBuilder.Append(" X ");
            stringBuilder.Append(Jogadores[1].Gol().getGol() + " ");
            stringBuilder.Append(Jogadores[1].Getnome());
            stringBuilder.Append("\n");
            stringBuilder.Append("\n");

            stringBuilder.Append("--------------ENERGIAS---------------");
            stringBuilder.Append("\n");
            stringBuilder.Append(Jogadores[0].Getnome() + ": ");
            stringBuilder.Append(Jogadores[0].Energia ().getEnergia  ());
            stringBuilder.Append("\n");
            stringBuilder.Append(Jogadores[1].Getnome() + ": ");
            stringBuilder.Append(Jogadores[1].Energia ().getEnergia ());
            stringBuilder.Append("\n");
            stringBuilder.Append("\n");
            
            stringBuilder.Append("--------------PONTOS---------------");
            stringBuilder.Append("\n");
            stringBuilder.Append(Jogadores[0].Getnome() + ": ");
            stringBuilder.Append(Jogadores[0].Pontos ().getPontos ());
            stringBuilder.Append("\n");
            stringBuilder.Append(Jogadores[1].Getnome() + ": ");
            stringBuilder.Append(Jogadores[1].Pontos().getPontos());
            stringBuilder.Append("\n");
            stringBuilder.Append("-----------------------------");


            Console.WriteLine ( stringBuilder.ToString() );
        }
    }
}

