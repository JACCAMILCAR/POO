namespace Tienda
{
    public abstract class Productos
    {
        public abstract string nombre { get; set; }
        public abstract double largo { get; set; }
        public abstract double ancho { get; set; }
        public abstract double alto { get; set; }
        public abstract bool medidaGramo { get; set; }
        public abstract bool medidaUnitaria { get; set; }
    }
}
