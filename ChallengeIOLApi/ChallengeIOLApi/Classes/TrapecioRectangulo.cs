using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeIOLApi.Classes
{
    /// <summary>
    /// Clase TrapecioRectangulo, hereda de Rectangulo
    /// </summary>
    public class TrapecioRectangulo: Rectangulo
    {
        protected double _c;
        protected double _d;
        public TrapecioRectangulo(string nombre, double a, double b, double c, double d) : base(nombre,a,b)
        {
            _c = c;
            _d = d;
        }
        /// <summary>
        /// Calcula el área de un Trapecio Rectangulo
        /// </summary>
        /// <returns>Retorna el área de un Trapecio Rectangulo</returns>
        public override double GetArea()
        {
            return _a * ((_b + _c) / 2);
        }
        /// <summary>
        /// Calcula el perímetro de un Trapecio Rectangulo
        /// </summary>
        /// <returns>Retorna el perímetro de un Trapecio Rectangulo</returns>
        public override double GetPerimetro()
        {
            return _a + _b + _c + _d;
        }
    }
}
