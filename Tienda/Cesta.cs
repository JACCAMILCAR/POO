using System;
using System.Collections.Generic;

namespace Tienda
{
    static class Cesta
    {
        static double area = 9600;
        static int cantidad = 4;
        static int[] cantidadGeneral = new int[100];
        static List<Fruta> lista = new List<Fruta>();

        public static void GenerarCanasta()
        {
            Kiwi kiwi1 = new Kiwi(true, 20, false, "Kiwi alemana", 110, 20, 20, false, true);
            Kiwi kiwi2 = new Kiwi(true, 20, false, "Kiwi espanola", 120, 80, 19, false, true);
            Naranja naranja1 = new Naranja(true, 36, false, "Naranja chilena", 34, 35, 29, false, true);
            Sandia sandia1 = new Sandia(true, 36, true, "Sandia Asiatica", 34, 35, 29, false, true);
            Sandia sandia2 = new Sandia(true, 36, false, "Sandia Asiatica", 34, 35, 29, false, true);

            lista.Add(kiwi1);
            lista.Add(kiwi2);
            lista.Add(naranja1);
            lista.Add(sandia1);
            lista.Add(sandia2);
        }

        public static void MostrarLista()
        {
            Operacion o = new Operacion();
            cantidadGeneral[0] = 1;
            for (int i=0; i < lista.Count; i++)
            {
                if (i > 0)
                {
                    cantidadGeneral[i] = cantidadGeneral[i - 1];
                }
                if (o.valida(lista[i].largo,lista[i].ancho,lista[i].alto) == true && cantidadGeneral[i] <= cantidad)
                {
                    if (i > 0 && o.validaFruta(lista[i-1].delicada, cantidadGeneral[i], cantidadGeneral[i-1]) == true)
                    {
                        if (o.area(lista[i].largo, lista[i].ancho) > area)
                        {
                            cantidadGeneral[i] = cantidadGeneral[i-1] + 1;
                            if (cantidadGeneral[i] > 1)
                            {
                                area = 9600;
                            }
                        }
                        else
                        {
                            cantidadGeneral[i] = cantidadGeneral[i - 1];
                        }
                        Console.WriteLine("|Nombres: " + lista[i].nombre + "| Es delicado: " + lista[i].delicada + "| Pertenece a la cesta: " + cantidadGeneral[i] + "| Largo: " + lista[i].largo + "| Ancho: " + lista[i].ancho + "| Alto: " + lista[i].alto);
                    }
                    else if (i == 0)
                    {
                        
                        Console.WriteLine("|Nombre de : " + lista[i].nombre + "| Es delicado: " + lista[i].delicada + "| Pertenece a la cesta: " + cantidadGeneral[i] + "| Largo: " + lista[i].largo + "| Ancho: " + lista[i].ancho + "| Alto: " + lista[i].alto);
                    }
                    else
                    {
                        cantidadGeneral[i] = cantidadGeneral[i-1] + 1;
                        if (cantidadGeneral[i] > 1)
                        {
                            area = 9600;
                        }
                        Console.WriteLine("|Nombre: " + lista[i].nombre + "| Es delicado: " + lista[i].delicada + "| Pertenece a la cesta: " + cantidadGeneral[i] + "| Largo: " + lista[i].largo + "| Ancho: " + lista[i].ancho + "| Alto: " + lista[i].alto);
                    }
                    area = area - o.area(lista[i].largo, lista[i].ancho);
                }
                else if (cantidadGeneral[i] > cantidad)
                {
                    Console.WriteLine("Ya se terminaron las canastas...");
                }
                else
                {
                    Console.WriteLine("El tamano no es adecuado para la cesta |Nombre: " + lista[i].nombre + "| Largo: " + lista[i].largo + "| Ancho: " + lista[i].ancho + "| Alto: " + lista[i].alto);
                }
            }
        }
    }
}
