namespace Tienda
{
    class Sandia:FrutaDulce
    {
        bool diuretico { get; set; }

        public Sandia(bool diureticoP, double cantidadPotasioP, bool delicadaP, string nombreP, double largoP, double anchoP, double altoP, bool medidaGramoP, bool medidaUnitariaP) : base(cantidadPotasioP,delicadaP, nombreP, largoP, anchoP, altoP, medidaGramoP, medidaUnitariaP)
        {
            diuretico = diureticoP;
        }
    }
}
