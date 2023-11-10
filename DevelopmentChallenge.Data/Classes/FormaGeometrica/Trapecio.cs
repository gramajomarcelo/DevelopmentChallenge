using System;
using System.Configuration;

namespace DevelopmentChallenge.Data.Classes.FormaGeometrica
{
    public class Trapecio : FormaGeometrica
    {
        private readonly decimal _base;
        private readonly decimal _altura;

        public Trapecio(decimal piso, decimal altura)
        {
            if (piso == altura)
            {
                throw new ArgumentException("La base y la altura no pueden ser iguales.");
            }

            _base = piso;
            _altura = altura;
        }

        public override decimal CalcularArea()
        {
            return _base * _altura;
        }

        public override decimal CalcularPerimetro()
        {
            return (_base + _altura ) * 2;
        }

        public override FormaGeometricaEnum TipoFormaGeometrica => FormaGeometricaEnum.Trapecio;
    }
}
