using DevelopmentChallenge.Data.Classes.FormaGeometrica;
using DevelopmentChallenge.Data.Classes.Idioma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class FiguraGeometricaReporte
    {
        public static string Imprimir(List<FormaGeometrica.FormaGeometrica> formas, int idioma)
        {
            FormatProviderManager formatProviderManager = new FormatProviderManager();
            var sb = new StringBuilder();

            try
            {
                if (!formas.Any())
                {
                    sb.Append(string.Format("<h1>{0}!</h1>", Idioma.IdiomaMensajes.ObtenerMensaje(idioma, "ListaVacia")));
                }
                else
                {
                    IFormatProvider formatProvider = formatProviderManager.GetFormatProvider(idioma);
                
                    // HEADER
                    ObtenerHeader(sb, idioma);

                    // CALCULATION
                    ObtenerCalculos(sb, formas, idioma, formatProvider);

                    // FOOTER
                    ObtenerFooter(sb, formas, idioma, formatProvider);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al imprimir el reporte: " + ex.Message);
                throw;
            }
            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, int tipo, int idioma, IFormatProvider formatProvider)
        {
            try
            {
                if (cantidad > 0)
                {
                    return string.Format(formatProvider, "{0} {1} | {2} {3:#.##} | {4} {5:#.##} <br/>",
                        cantidad,
                        IdiomaMensajes.TraducirForma(tipo, cantidad, idioma),
                        IdiomaMensajes.ObtenerMensaje(idioma, "Area"),
                        area,
                        IdiomaMensajes.ObtenerMensaje(idioma, "Perimetro"),
                        perimetro);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al obtener el calculo de la forma geometrica: " + ex.Message);
                throw;
            }

            return string.Empty;
        }

        private static void ObtenerHeader(StringBuilder sb, int idioma)
        {
            try 
            { 
                sb.Append(string.Format("<h1>{0}</h1>", IdiomaMensajes.ObtenerMensaje(idioma, "ReporteFormas")));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al obtener el obtener el header: " + ex.Message);
                throw;
            }
        }

        private static void ObtenerCalculos(StringBuilder sb, List<FormaGeometrica.FormaGeometrica> formas, int idioma, IFormatProvider formatProvider)
        {
            var formaDict = new Dictionary<Type, List<FormaGeometrica.FormaGeometrica>>();

            try 
            {
                foreach (var forma in formas)
                {
                    var tipo = forma.GetType();
                    if (!formaDict.ContainsKey(tipo))
                    {
                        formaDict[tipo] = new List<FormaGeometrica.FormaGeometrica>();
                    }
                    formaDict[tipo].Add(forma);
                }

                foreach (var fm in formaDict)
                {
                    FormaGeometricaEnum tipoForma = (FormaGeometricaEnum)Enum.Parse(typeof(FormaGeometricaEnum), fm.Key.Name);
                    var cantidad = fm.Value.Count;
                    var areaTotal = fm.Value.Sum(f => f.CalcularArea());
                    var perimetroTotal = fm.Value.Sum(f => f.CalcularPerimetro());
                    sb.Append(ObtenerLinea(cantidad, areaTotal, perimetroTotal, (int)tipoForma, idioma, formatProvider));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al obtener el obtener los calculos: " + ex.Message);
                throw;
            }
        }

        private static void ObtenerFooter(StringBuilder sb, List<FormaGeometrica.FormaGeometrica> formas, int idioma, IFormatProvider formatProvider)
        {
            try
            {
                var totalCantidad = formas.Count;
                var totalArea = formas.Sum(f => f.CalcularArea());
                var totalPerimetro = formas.Sum(f => f.CalcularPerimetro());

                sb.Append(string.Format(formatProvider, "{0}:<br/>{1} {2} {3} {4:#.##} {5} {6:#.##}",
                        IdiomaMensajes.ObtenerMensaje(idioma, "Total"),
                        totalCantidad,
                        IdiomaMensajes.ObtenerMensaje(idioma, "Formas"),
                        IdiomaMensajes.ObtenerMensaje(idioma, "Perimetro"),
                        totalPerimetro,
                        IdiomaMensajes.ObtenerMensaje(idioma, "Area"),
                        totalArea));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al obtener el obtener el footer: " + ex.Message);
                throw;
            }
        }
    }
}
