using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoAbstractFactory
{
    public class FabricaFiat : FabricaDeCarro
    {
        public CarroSedan criarCarroSedan()
        {
            return new Siena();
        }

        public CarroPopular criarCarroPopular()
        {
            return new Palio();
        }
    }
}
