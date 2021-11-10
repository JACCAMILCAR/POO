using System;
using System.Collections.Generic;

namespace Tienda
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion, delicada, tipoVerdura, listaGeneral, cantidadGlobal=1;
            double largo, ancho, alto, x;
            double area = 0, areaTotal = 9600;
            string nombreP, tipoFruta;

            Operacion operacion1 = new Operacion();
            List<Fruta> lista = new List<Fruta>();
            List<Verdura> listaVerdura = new List<Verdura>();

            Menu.MenuInicio();
            Cesta.cantidad = Int32.Parse(Console.ReadLine());

            Menu.MenuTienda();
            opcion = Int32.Parse(Console.ReadLine());

            while (opcion != 4)
            {
                if (opcion == 1)
                {
                    Console.Write("Ingrese el nombre :");
                    nombreP = Console.ReadLine();

                    Console.Write("Ingrese al tipo que pertenece :");
                    tipoFruta = Console.ReadLine();

                    Console.Write("Ingrese el largo :");
                    largo = Double.Parse(Console.ReadLine());

                    Console.Write("Ingrese el ancho :");
                    ancho = Double.Parse(Console.ReadLine());

                    Console.Write("Ingrese el alto :");
                    alto = Double.Parse(Console.ReadLine());

                    Menu.delicado();
                    delicada = Int32.Parse(Console.ReadLine());
                    
                    area = largo * ancho;
                    x = operacion1.Rest(largo, ancho, alto, area);
                    if (x >= 0 && Cesta.cantidad >= cantidadGlobal)
                    {
                        areaTotal = areaTotal - area;
                        if (lista.Count > 0 && operacion1.validar(lista[lista.Count-1].delicada, cantidadGlobal, lista[lista.Count-1].numeroCesta) == true)
                        {
                            if (area >= areaTotal)
                            {
                                cantidadGlobal = cantidadGlobal + 1;
                                if (cantidadGlobal > 1)
                                {
                                    areaTotal = 9600;
                                }
                            }
                            lista.Add(new Fruta { nombre = nombreP, tipoFruta = tipoFruta, delicada = Menu.delicado(delicada), largo = largo, ancho = ancho, alto = alto, numeroCesta = cantidadGlobal });
                        }
                        else if (lista.Count==0)
                        {
                            lista.Add(new Fruta { nombre = nombreP, tipoFruta = tipoFruta, delicada = Menu.delicado(delicada), largo = largo, ancho = ancho, alto = alto, numeroCesta = cantidadGlobal });
                        }
                        else
                        {
                            cantidadGlobal = cantidadGlobal + 1;
                            if (cantidadGlobal > 1)
                            {
                                areaTotal = 9600;
                            }
                            lista.Add(new Fruta { nombre = nombreP, tipoFruta = tipoFruta, delicada = Menu.delicado(delicada), largo = largo, ancho = ancho, alto = alto, numeroCesta = cantidadGlobal });
                        }
                    }
                    else
                    {
                        Console.WriteLine("No es posible ingresar el producto por su mayor tamano. O puede ser posible que se hayan acabado las cestas.");
                    }
                }
                else if (opcion == 2)
                {
                    Console.Write("Ingrese el nombre :");
                    nombreP = Console.ReadLine();

                    Menu.TipoVerdura();
                    tipoVerdura = Int32.Parse(Console.ReadLine());

                    Console.Write("Ingrese el largo :");
                    largo = Double.Parse(Console.ReadLine());

                    Console.Write("Ingrese el ancho :");
                    ancho = Double.Parse(Console.ReadLine());

                    Console.Write("Ingrese el alto :");
                    alto = Double.Parse(Console.ReadLine());

                    area = largo * ancho;
                    x = operacion1.Rest(largo, ancho, alto, area);
                    if (x >= 0 && Cesta.cantidad >= cantidadGlobal)
                    {
                        areaTotal = areaTotal - area;
                        if (listaVerdura.Count > 0 && operacion1.validarVedura(tipoVerdura, listaVerdura[listaVerdura.Count - 1].tipoVerdura, cantidadGlobal, listaVerdura[listaVerdura.Count - 1].numeroCesta) == true)
                        {
                            if (area >= areaTotal)
                            {
                                cantidadGlobal = cantidadGlobal + 1;
                                if (cantidadGlobal > 1)
                                {
                                    areaTotal = 9600;
                                }
                            }
                            listaVerdura.Add(new Verdura { nombre = nombreP, tipoVerdura = tipoVerdura, largo = largo, ancho = ancho, alto = alto, numeroCesta = cantidadGlobal });
                        }
                        else if (listaVerdura.Count == 0)
                        {
                            listaVerdura.Add(new Verdura { nombre = nombreP, tipoVerdura = tipoVerdura, largo = largo, ancho = ancho, alto = alto, numeroCesta = cantidadGlobal });
                        }
                        else
                        {
                            cantidadGlobal = cantidadGlobal + 1;
                            if (cantidadGlobal > 1)
                            {
                                areaTotal = 9600;
                            }
                            listaVerdura.Add(new Verdura { nombre = nombreP, tipoVerdura = tipoVerdura, largo = largo, ancho = ancho, alto = alto, numeroCesta = cantidadGlobal });
                        }
                    }
                    else
                    {
                        Console.WriteLine("No es posible ingresar el producto por su mayor tamano. O puede ser posible que se hayan acabado las cestas.");
                    }
                }
                else if (opcion == 3)
                {
                    for (int i = 0; i < lista.Count; i++)
                    {
                        Console.WriteLine("|Nombre: "+lista[i].nombre + "| Tipo de fruta: " + lista[i].tipoFruta + "| Es delicado: " + lista[i].delicada + "| Pertenece a la cesta: " + lista[i].numeroCesta);
                    }

                    for (int i = 0; i < listaVerdura.Count; i++)
                    {
                        Console.WriteLine("|Nombre: " + listaVerdura[i].nombre + "| Tipo de fruta: " + listaVerdura[i].tipoVerdura + "| Pertenece a la cesta: " + listaVerdura[i].numeroCesta);
                    }
                }
                Menu.MenuTienda();
                opcion = Int32.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
