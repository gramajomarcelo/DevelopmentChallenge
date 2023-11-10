namespace DevelopmentChallenge.Data.Classes.FormaGeometrica
{
    public class Cuadrado : FormaGeometrica
    {
        private readonly decimal _lado;

        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return 4 * _lado;
        }

        public override FormaGeometricaEnum TipoFormaGeometrica => FormaGeometricaEnum.Cuadrado;
    }
}
