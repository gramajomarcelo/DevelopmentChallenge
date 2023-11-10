using System;

namespace DevelopmentChallenge.Data.Classes.FormaGeometrica.Triangulo
{
    public class TrianguloEscaleno : Triangulo
    {
        public TrianguloEscaleno(decimal lado1, decimal lado2, decimal lado3) : base(lado1, lado2, lado3)
        {
        }

        public override decimal CalcularArea()
        {
            decimal s = (_lado1 + _lado2 + _lado3) / 2;
            decimal area = (decimal)Math.Sqrt((double)(s * (s - _lado1) * (s - _lado2) * (s - _lado3)));
            return area;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado1 + _lado2 + _lado3;
        }

        public override FormaGeometricaEnum TipoFormaGeometrica => FormaGeometricaEnum.TrianguloEscaleno;
    }
}
