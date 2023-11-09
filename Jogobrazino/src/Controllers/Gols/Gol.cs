using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.Gols
{
    public class Gol : Igol
    {
        private int gol = 0;


        public void addGol()
        {
            gol++;
        }
        public int getGol ()
        {
            return gol;
        }
    }

}
