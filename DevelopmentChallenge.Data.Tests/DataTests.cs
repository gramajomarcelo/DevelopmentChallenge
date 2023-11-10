using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Classes.FormaGeometrica;
using DevelopmentChallenge.Data.Classes.FormaGeometrica.Triangulo;
using DevelopmentChallenge.Data.Classes.Idioma;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FiguraGeometricaReporte.Imprimir(new List<FormaGeometrica>(), 1));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FiguraGeometricaReporte.Imprimir(new List<FormaGeometrica>(), 2));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            Assert.AreEqual("<h1>Lista vuota di forme!</h1>",
                FiguraGeometricaReporte.Imprimir(new List<FormaGeometrica>(), 3));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> {new Cuadrado(5)};

            var resumen = FiguraGeometricaReporte.Imprimir(cuadrados, (int)IdiomaEnum.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = FiguraGeometricaReporte.Imprimir(cuadrados, (int)IdiomaEnum.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCirculo()
        {
            var circulos = new List<FormaGeometrica> { new Circulo(7) };

            var resumen = FiguraGeometricaReporte.Imprimir(circulos, (int)IdiomaEnum.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>1 Circle | Area 38,48 | Perimeter 21,99 <br/>TOTAL:<br/>1 shapes Perimeter 21,99 Area 38,48", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCirculos()
        {
            var circulos = new List<FormaGeometrica>
            {
                new Circulo(5),
                new Circulo(2),
                new Circulo(3)
            };

            var resumen = FiguraGeometricaReporte.Imprimir(circulos, (int)IdiomaEnum.Castellano);
    
            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Círculos | Area 29,85 | Perimetro 31,42 <br/>TOTAL:<br/>3 formas Perimetro 31,42 Area 29,85", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FiguraGeometricaReporte.Imprimir(formas, (int)IdiomaEnum.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FiguraGeometricaReporte.Imprimir(formas, (int)IdiomaEnum.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FiguraGeometricaReporte.Imprimir(formas, (int)IdiomaEnum.Italiano);

            Assert.AreEqual(
                "<h1>Report di forme</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>2 Cerchi | Area 13,01 | Perimetro 18,06 <br/>3 Triangoli | Area 49,64 | Perimetro 51,6 <br/>TOTALE:<br/>7 forme Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var trapecios = new List<FormaGeometrica> { new Trapecio(5,6) };

            var resumen = FiguraGeometricaReporte.Imprimir(trapecios, (int)IdiomaEnum.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>1 Trapezium | Area 30 | Perimeter 22 <br/>TOTAL:<br/>1 shapes Perimeter 22 Area 30", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapecios()
        {
            var trapecios = new List<FormaGeometrica>
            {
                new Trapecio(6.6M, 2.32M),
                new Trapecio(11, 2.4M),
                new Trapecio(3,5)
            };

            var resumen = FiguraGeometricaReporte.Imprimir(trapecios, (int)IdiomaEnum.Italiano);

            Assert.AreEqual("<h1>Report di forme</h1>3 Trapezio | Area 56,71 | Perimetro 60,64 <br/>TOTALE:<br/>3 forme Perimetro 60,64 Area 56,71", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnIngles()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Trapecio(5,6),
            };

            var resumen = FiguraGeometricaReporte.Imprimir(formas, (int)IdiomaEnum.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>1 Trapezium | Area 30 | Perimeter 22 <br/>TOTAL:<br/>8 shapes Perimeter 119,66 Area 121,65",
                resumen);

        }

        [TestCase]
        public void TestResumenListaConUnTriangulo()
        {
            var circulos = new List<FormaGeometrica> { new TrianguloEquilatero(7) };

            var resumen = FiguraGeometricaReporte.Imprimir(circulos, (int)IdiomaEnum.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>1 Triangle | Area 21,22 | Perimeter 21 <br/>TOTAL:<br/>1 shapes Perimeter 21 Area 21,22", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTriangulo()
        {
            var circulos = new List<FormaGeometrica>
            {
                new TrianguloEquilatero(8),
                new TrianguloEquilatero(7),
                new TrianguloEquilatero(9),
                new TrianguloEquilatero(11)
            };

            var resumen = FiguraGeometricaReporte.Imprimir(circulos, (int)IdiomaEnum.Italiano);

            Assert.AreEqual("<h1>Report di forme</h1>4 Triangoli | Area 136,4 | Perimetro 105 <br/>TOTALE:<br/>4 forme Perimetro 105 Area 136,4", resumen);
        }
    }
}
