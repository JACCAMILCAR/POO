using System;

namespace Tienda
{
    static class Menu
    {
        static public void MenuInicio()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("BIENVENIDO A LA TIENDA****");
            Console.WriteLine("Ingrese la cantidad de cesta");
            Console.WriteLine("**************************");
        }
        static public void MenuTienda()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("1. Ingresar nueva fruta***");
            Console.WriteLine("2. Ingresar nueva verdura*");
            Console.WriteLine("3. Ver Lista**************");
            Console.WriteLine("4. Salir******************");
            Console.WriteLine("**************************");
        }

        static public void delicado()
        {
            Console.WriteLine("Presione '1' si la fruta es delicada. Presione '0' si la fruta no es delicada");
        }

        static public bool delicado(int valor)
        { 
            if(valor == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public void TipoVerdura()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("1. Verduras de hojas");
            Console.WriteLine("2. Verduras de Bulbo");
            Console.WriteLine("3. Verduras de raíz");
            Console.WriteLine("4. Verduras de Flor o Inflorescencias");
            Console.WriteLine("5. Verduras de Brote");
            Console.WriteLine("6. Verduras de Fruto");
            Console.WriteLine("7. Verduras de Tallo");
            Console.WriteLine("8. Tubérculos");
            Console.Write("Elija una opcion :");
        }
    }
}
