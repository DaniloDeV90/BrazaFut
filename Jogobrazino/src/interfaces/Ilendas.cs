using Jogobrazino.src.Controllers.LendasController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogobrazino.src.interfaces
{
    public interface Ilendas
    {
        public void addLegends(string legend);

        public string ReturnLegend();


        public void MostrarArr();
       
    }
}
