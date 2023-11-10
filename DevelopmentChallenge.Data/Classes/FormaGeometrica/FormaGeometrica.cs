namespace DevelopmentChallenge.Data.Classes.FormaGeometrica
{
    public abstract class FormaGeometrica
    {
        public abstract FormaGeometricaEnum TipoFormaGeometrica { get; }
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
    }
}
