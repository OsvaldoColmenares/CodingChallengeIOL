using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeIOLApi.Resource
{
    public class Traduccion
    {
        private readonly CultureInfo _culture;
        public Traduccion(CultureInfo culture)
        {
            _culture = culture;
        }

        public string Listavaciadeformas => LocalizationUtils<Traduccion>.GetValue("Listavaciadeformas", _culture);
        public string Reportedeformas => LocalizationUtils<Traduccion>.GetValue("Reportedeformas", _culture);
        public string Perimetro => LocalizationUtils<Traduccion>.GetValue("Perimetro", _culture);
        public string Cuadrado => LocalizationUtils<Traduccion>.GetValue("Cuadrado", _culture);
        public string Cuadrados => LocalizationUtils<Traduccion>.GetValue("Cuadrados", _culture);
        public string Circulo => LocalizationUtils<Traduccion>.GetValue("Circulo", _culture);
        public string Circulos => LocalizationUtils<Traduccion>.GetValue("Circulos", _culture);
        public string Triangulo => LocalizationUtils<Traduccion>.GetValue("Triangulo", _culture);
        public string Triangulos => LocalizationUtils<Traduccion>.GetValue("Triangulos", _culture);
        public string Formas => LocalizationUtils<Traduccion>.GetValue("Formas", _culture);
        public string Rectangulo => LocalizationUtils<Traduccion>.GetValue("Rectangulo", _culture);
        public string TrianguloEquilatero => LocalizationUtils<Traduccion>.GetValue("Triangulo Equilatero", _culture);
        public string TrapecioRectangulo => LocalizationUtils<Traduccion>.GetValue("Trapecio Rectangulo", _culture);

    }
}
