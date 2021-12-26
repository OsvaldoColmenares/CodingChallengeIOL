using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeIOLApi.Classes
{
    /// <summary>
    /// Clase Rectangulo, hereda de Cuadrado
    /// </summary>
    public class Rectangulo: Cuadrado
    {
        protected double _b;       
        public Rectangulo(string nombre, double a, double b): base (nombre,a)   
        {
            _b = b;
        }
        /// <summary>
        /// Calcula el área de un Rectangulo
        /// </summary>
        /// <returns>Retorna el área de un Rectangulo</returns>
        public override double GetArea()
        {
            return _a * _b;
        }
        /// <summary>
        /// Calcula el perímetro de un Rectangulo
        /// </summary>
        /// <returns>Retorna el perímetro de un Rectangulo</returns>
        public override double GetPerimetro()
        {
            return (2 * _a) + (2 * _b);
        }
    }
}
