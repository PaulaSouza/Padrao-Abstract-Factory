using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoAbstractFactory
{
    public class FabricaFord : FabricaDeCarro
    {
        public CarroSedan criarCarroSedan()
        {
            return new FiestaSedan();
        }

        public CarroPopular criarCarroPopular()
        {
            return new Fiesta();
        }
    }
}
