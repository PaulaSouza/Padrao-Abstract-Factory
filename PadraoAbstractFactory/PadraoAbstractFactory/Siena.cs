using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoAbstractFactory
{
    public class Siena : CarroSedan
    {
        public void exibirInfoSedan()
        {
            Console.WriteLine("Modelo: Siena\nFábrica: Fiat\nCategoria: Sedan\n");
        }
    }
}
