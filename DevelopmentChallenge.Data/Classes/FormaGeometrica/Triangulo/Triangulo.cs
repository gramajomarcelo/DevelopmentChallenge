namespace DevelopmentChallenge.Data.Classes.FormaGeometrica.Triangulo
{
    public abstract class Triangulo : FormaGeometrica
    {
        protected decimal _lado1;
        protected decimal _lado2;
        protected decimal _lado3;

        public Triangulo(decimal lado1, decimal lado2, decimal lado3)
        {
            _lado1 = lado1;
            _lado2 = lado2;
            _lado3 = lado3;
        }
    }
}