using ChallengeIOLApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeIOLApi.Classes
{
    /// <summary>
    /// Clase Circulo, hereda de Forma e IForma
    /// </summary>
    public class Circulo : Forma, IForma
    {
        protected double _a;

        public Circulo(string nombre, double a) : base(nombre)
        {
            _a = a;
        }

        /// <summary>
        /// Calcula el área de un Circulo
        /// </summary>
        /// <returns>Retorna el área del Circulo</returns>
        public virtual double GetArea()
        {
            return Math.PI * Math.Pow(_a, 2);
        }

        /// <summary>
        /// Calcula el perímetro de un Circulo
        /// </summary>
        /// <returns>Retorna el perímetro de un Circulo</returns>
        public virtual double GetPerimetro()
        {
            return 2 * Math.PI * _a;
        }

    }
}
