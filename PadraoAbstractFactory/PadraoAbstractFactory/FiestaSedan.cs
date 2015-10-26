using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoAbstractFactory
{
    public class FiestaSedan : CarroSedan
    {
        public void exibirInfoSedan()
        {
            Console.WriteLine("Modelo: Fiesta Sedan\nFábrica: Ford\nCategoria: Sedan\n");
        }
    }
}
