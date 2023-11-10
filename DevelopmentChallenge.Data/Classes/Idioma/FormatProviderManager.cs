using DevelopmentChallenge.Data.Classes.FormaGeometrica;
using System.Collections.Generic;
using System.Globalization;
using System;

namespace DevelopmentChallenge.Data.Classes.Idioma
{
    public class FormatProviderManager
    {
        private Dictionary<int, IFormatProvider> formatProviders;

        public FormatProviderManager()
        {
            formatProviders = new Dictionary<int, IFormatProvider>
        {
            { (int)IdiomaEnum.Castellano, new CultureInfo("es-ES") },
            { (int)IdiomaEnum.Ingles, new CultureInfo("es-ES") },
            { (int)IdiomaEnum.Italiano, new CultureInfo("it-IT") },
        };
        }

        public IFormatProvider GetFormatProvider(int idioma)
        {
            if (formatProviders.ContainsKey(idioma))
            {
                return formatProviders[idioma];
            }
            return CultureInfo.InvariantCulture;
        }
    }
}
