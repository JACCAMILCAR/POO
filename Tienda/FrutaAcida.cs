namespace Tienda
{
    public class FrutaAcida: Fruta
    {
        double cantidadVitaminaC;

        public FrutaAcida(double cantidadVitaminaCP, bool delicadaP,string nombreP, double largoP, double anchoP, double altoP, bool medidaGramoP, bool medidaUnitariaP) :base (delicadaP, nombreP, largoP, anchoP, altoP, medidaGramoP, medidaUnitariaP)
        {
            cantidadVitaminaC = cantidadVitaminaCP;
        }
    }
}
