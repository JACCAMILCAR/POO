using System;
using System.Collections.Generic;

namespace Tienda
{
    class Program
    {
        static void Main(string[] args)
        {
            Cesta.GenerarCanasta();
            Cesta.MostrarLista();

            Console.ReadKey();
        }
    }
}
