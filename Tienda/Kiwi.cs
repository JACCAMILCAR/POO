using System;

namespace Tienda
{
    public class Kiwi:FrutaAcida
    {
        bool pielBellosa { get; set; }

        public Kiwi(bool pielBellosaP, double cantidadVitaminaCP, bool delicadaP,string nombreP, double largoP, double anchoP, double altoP, bool medidaGramoP, bool medidaUnitariaP) : base(cantidadVitaminaCP, delicadaP, nombreP,largoP, anchoP, altoP, medidaGramoP, medidaUnitariaP)
        {
            pielBellosa = pielBellosaP;
        }
    }
}
