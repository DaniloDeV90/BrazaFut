using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.Controllers.LadoCobrado
{
    public class ladoCobrado :  IladoCobrado
    {

        private string lado = "";

      public   string getLado()
        {
            return lado;
        }


      public    void setLado(string lado)
        {
            this.lado = lado;
        }
    }
}
