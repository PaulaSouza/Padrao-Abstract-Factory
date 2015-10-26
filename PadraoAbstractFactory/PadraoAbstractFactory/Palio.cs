using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoAbstractFactory
{
    public class Palio : CarroPopular
    {
        public void exibirInfoPopular()
        {
            Console.WriteLine("Modelo: Palio\nFábrica: Fiat\nCategoria: Popular\n");
        }
    }
}
