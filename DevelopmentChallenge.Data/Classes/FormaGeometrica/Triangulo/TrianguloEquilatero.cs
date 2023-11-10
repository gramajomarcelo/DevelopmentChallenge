using System;

namespace DevelopmentChallenge.Data.Classes.FormaGeometrica.Triangulo
{
    public class TrianguloEquilatero : Triangulo
    {
        public TrianguloEquilatero(decimal lado) : base(lado, lado, lado)
        {
        }

        public override decimal CalcularArea()
        {
            decimal s = (_lado1 + _lado2 + _lado3) / 2;
            return (decimal)Math.Sqrt((double)(s * (s - _lado1) * (s - _lado2) * (s - _lado3)));
        }

        public override decimal CalcularPerimetro()
        {
            return _lado1 + _lado2 + _lado3;
        }

        public override FormaGeometricaEnum TipoFormaGeometrica => FormaGeometricaEnum.TrianguloEquilatero;
    }
}
