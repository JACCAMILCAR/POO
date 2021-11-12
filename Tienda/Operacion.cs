using System;
using System.Collections.Generic;

namespace Tienda
{
    class Operacion
    {
        public double area(double largo, double ancho)
        {
            return largo * ancho;
        }
        public bool valida(double largo, double ancho, double alto)
        {
            if(largo <= 120 && ancho <= 80 && alto <= 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool validaFruta(bool delicado, int cesta, int cestaLista)
        {
            if (delicado == false && cesta == cestaLista)
            { 
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool validarVedura(int tipoActual, int tipoAnterior, int cesta, int cestaLista)
        {
            if (tipoActual == tipoAnterior && cesta == cestaLista)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
}
}
