namespace Tienda
{
    class Verdura: Productos
    {
        public bool agradable { get; set; }
        public override string nombre { get; set; }
        public override double largo { get; set; }
        public override double ancho { get; set; }
        public override double alto { get; set; }
        public override bool medidaGramo { get; set; }
        public override bool medidaUnitaria { get; set; }

        public Verdura(bool agradableP, string nombreP, double largoP, double anchoP, double altoP, bool medidaGramoP, bool medidaUnitariaP)
        {
            nombre = nombreP;
            largo = largoP;
            ancho = anchoP;
            alto = altoP;
            medidaGramo = medidaGramoP;
            medidaUnitaria = medidaUnitariaP;
            agradable = agradableP;
        }
    }
}
