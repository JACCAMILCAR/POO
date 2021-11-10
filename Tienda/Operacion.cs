using System;
using System.Collections.Generic;

namespace Tienda
{
    class Operacion
    {
        public double Rest(double largo, double ancho, double alto, double area)
        {
            if(Cesta.largo >= largo && Cesta.ancho >= ancho && Cesta.alto >= alto && Cesta.area >= area)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public bool validar(bool delicado, int cesta, int cestaLista)
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
