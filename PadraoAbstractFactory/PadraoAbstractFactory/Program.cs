using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaDeCarro fabrica = new FabricaFiat();
            CarroSedan sedan = fabrica.criarCarroSedan();
            CarroPopular popular = fabrica.criarCarroPopular();
            sedan.exibirInfoSedan();
            popular.exibirInfoPopular();

            fabrica = new FabricaFord();
            sedan = fabrica.criarCarroSedan();
            popular = fabrica.criarCarroPopular();
            sedan.exibirInfoSedan();
            popular.exibirInfoPopular();

            Console.ReadLine();
        }
    }
}
