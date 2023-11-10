using System;

namespace DevelopmentChallenge.Data.Classes.FormaGeometrica.Triangulo
{
    public class TrianguloIsosceles : Triangulo
    {
        public TrianguloIsosceles(decimal lado1, decimal lado2) : base(lado1, lado2, lado2)
        {
        }

        public override decimal CalcularArea()
        {
            return 0;
            // Implementa el cálculo del área para un triángulo isósceles
        }

        public override decimal CalcularPerimetro()
        {
            return _lado1 + _lado2 + _lado3;
        }

        public override FormaGeometricaEnum TipoFormaGeometrica => FormaGeometricaEnum.TrianguloIsosceles;
    }
}
