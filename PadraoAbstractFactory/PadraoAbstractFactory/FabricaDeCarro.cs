using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoAbstractFactory
{
    public interface FabricaDeCarro
    {
        CarroSedan criarCarroSedan();

        CarroPopular criarCarroPopular();
        
    }
}
