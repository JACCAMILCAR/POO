namespace Tienda
{
    class FrutaDulce:Fruta
    {
        double cantidadPotasio { get; set; }

        public FrutaDulce(double cantidadPotasioP, bool delicadaP, string nombreP, double largoP, double anchoP, double altoP, bool medidaGramoP, bool medidaUnitariaP) : base(delicadaP, nombreP, largoP, anchoP, altoP, medidaGramoP, medidaUnitariaP)
        {
            cantidadPotasio = cantidadPotasioP;
        }
    }
}
