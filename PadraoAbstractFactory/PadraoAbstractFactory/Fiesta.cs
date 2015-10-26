using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoAbstractFactory
{
    public class Fiesta : CarroPopular
    {
        public void exibirInfoPopular()
        {
            Console.WriteLine("Modelo: Fiesta\nFábrica: Ford\nCategoria: Popular\n");
        }
    }
}
