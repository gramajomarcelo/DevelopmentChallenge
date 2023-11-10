using DevelopmentChallenge.Data.Classes.FormaGeometrica;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes.Idioma
{
    internal class IdiomaMensajes
    {
        private static readonly Dictionary<int, Dictionary<string, string>> Mensajes = new Dictionary<int, Dictionary<string, string>>
    {
        {
            (int)IdiomaEnum.Castellano,
            new Dictionary<string, string>
            {
                { "ListaVacia", "Lista vacía de formas" },
                { "ReporteFormas", "Reporte de Formas" },
                { "Forma", "forma" },
                { "Formas", "formas" },
                { "Perimetro", "Perimetro" },
                { "Area", "Area" },
                { "Total", "TOTAL" },
                { "Cuadrado", "Cuadrado" },
                { "Cuadrados", "Cuadrados" },
                { "Circulo", "Círculo" },
                { "Circulos", "Círculos" },
                { "Triangulo", "Triángulo" },
                { "Triangulos", "Triángulos" },
                { "TrianguloEquilatero", "Triangulo Equilatero" },
                { "TriangulosEquilateros", "Triangulos Equilateros" },
                { "TrianguloIsosceles", "Triangulo Isosceles" },
                { "TriangulosIsosceles", "Triangulos Isosceles" },
                { "TrianguloEscaleno", "Triangulo Escaleno" },
                { "TriangulosEscaleno", "Triangulos Escalenos" },
                { "Trapecio", "Trapecio" },
                { "Trapecios", "Trapecios" },
                { "MensajeInvalido", "Mensaje Invalido" },
            }
        },
        {
            (int)IdiomaEnum.Ingles,
            new Dictionary<string, string>
            {
                    { "ListaVacia", "Empty list of shapes" },
                    { "ReporteFormas", "Shapes report" },
                    { "Forma", "shape" },
                    { "Formas", "shapes" },
                    { "Perimetro", "Perimeter" },
                    { "Area", "Area" },
                    { "Total", "TOTAL" },
                    { "Cuadrado", "Square" },
                    { "Cuadrados", "Squares" },
                    { "Circulo", "Circle" },
                    { "Circulos", "Circles" },
                    { "Triangulo", "Triangle" },
                    { "Triangulos", "Triangles" },
                    { "TrianguloEquilatero", "Equilateral Triangle" },
                    { "TriangulosEquilateros", "Equilateral Triangles" },
                    { "TrianguloIsosceles", "Isosceles Triangle" },
                    { "TriangulosIsosceles", "Isosceles Triangles" },
                    { "TrianguloEscaleno", "Scalene Triangle" },
                    { "TriangulosEscaleno", "Scalene Triangles" },
                    { "Trapecio", "Trapezium" },
                    { "Trapecios", "Trapeziums" },
                    { "MensajeInvalido", "Invalid message" },
            }
        },
        {
            (int)IdiomaEnum.Italiano,
            new Dictionary<string, string>
            {
                    { "ListaVacia", "Lista vuota di forme" },
                    { "ReporteFormas", "Report di forme" },
                    { "Forma", "forma" },
                    { "Formas", "forme" },
                    { "Perimetro", "Perimetro" },
                    { "Area", "Area" },
                    { "Total", "TOTALE" },
                    { "Cuadrado", "Quadrato" },
                    { "Cuadrados", "Quadrati" },
                    { "Circulo", "Cerchio" },
                    { "Circulos", "Cerchi" },
                    { "Triangulo", "Triangolo" },
                    { "Triangulos", "Triangoli" },
                    { "TrianguloEquilatero", "Triangolo Equilatero" },
                    { "TriangulosEquilateros", "Triangoli Equilateri" },
                    { "TrianguloIsosceles", "Triangolo Isoscele" },
                    { "TriangulosIsosceles", "Triangoli Isosceli" },
                    { "TrianguloEscaleno", "Triangolo Scaleno" },
                    { "TriangulosEscaleno", "Triangoli Scaleni" },
                    { "Trapecio", "Trapezio" },
                    { "Trapecios", "Trapezi" },
                    { "MensajeInvalido", "Messaggio non valido" },
            }
        }
    };

        public static string ObtenerMensaje(int idioma, string claveMensaje)
        {
            if (Mensajes.ContainsKey(idioma) && Mensajes[idioma].ContainsKey(claveMensaje))
            {
                return Mensajes[idioma][claveMensaje];
            }

            return Mensajes[idioma]["MensajeInvalido"];
        }

        public static string TraducirForma(int tipo, int cantidad, int idioma)
        {
            switch (tipo)
            {
                case (int)FormaGeometricaEnum.Cuadrado:
                    return cantidad == 1 ? IdiomaMensajes.ObtenerMensaje(idioma, "Cuadrado") : IdiomaMensajes.ObtenerMensaje(idioma, "Cuadrados");
                case (int)FormaGeometricaEnum.Circulo:
                    return cantidad == 1 ? IdiomaMensajes.ObtenerMensaje(idioma, "Circulo") : IdiomaMensajes.ObtenerMensaje(idioma, "Circulos");
                case (int)FormaGeometricaEnum.TrianguloEquilatero:
                    return cantidad == 1 ? IdiomaMensajes.ObtenerMensaje(idioma, "Triangulo") : IdiomaMensajes.ObtenerMensaje(idioma, "Triangulos");
                case (int)FormaGeometricaEnum.TrianguloIsosceles:
                    return cantidad == 1 ? IdiomaMensajes.ObtenerMensaje(idioma, "TrianguloIsosceles") : IdiomaMensajes.ObtenerMensaje(idioma, "TriangulosIsosceles");
                case (int)FormaGeometricaEnum.TrianguloEscaleno:
                    return cantidad == 1 ? IdiomaMensajes.ObtenerMensaje(idioma, "TrianguloEscaleno") : IdiomaMensajes.ObtenerMensaje(idioma, "TriangulosEscalenos");
                case (int)FormaGeometricaEnum.Trapecio:
                    return cantidad == 1 ? IdiomaMensajes.ObtenerMensaje(idioma, "Trapecio") : IdiomaMensajes.ObtenerMensaje(idioma, "Trapecio");
                default:
                    return string.Empty;
            }
        }
    }
}
