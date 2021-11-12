namespace Tienda
{
    public class Naranja:FrutaAcida
    {
        bool familiaRutacea { get; set; }
        public Naranja(bool familiaRutaceaP, double cantidadVitaminaCP, bool delicadaP, string nombreP, double largoP, double anchoP, double altoP, bool medidaGramoP, bool medidaUnitariaP) : base(cantidadVitaminaCP, delicadaP, nombreP, largoP, anchoP, altoP, medidaGramoP, medidaUnitariaP)
        {
            familiaRutacea = familiaRutaceaP;
        }
    }
}
