using ChallengeIOLApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeIOLApi.Classes
{
    /// <summary>
    /// Clase TrianguloEquilatero, hereda de Forma e IForma
    /// </summary>
    public class TrianguloEquilatero : Forma, IForma
    {
        protected double _a;
     
        public TrianguloEquilatero(string nombre, double a) : base (nombre)
        {           
            _a = a;
        }
        /// <summary>
        /// Calcula el área de un Triangulo Equilatero
        /// </summary>
        /// <returns>Retorna el área de un Triangulo Equilatero</returns>
        public virtual double GetArea()
        {
            return ((Math.Pow(_a, 2)) * (Math.Sqrt(3))) / 4;
        }
        /// <summary>
        /// Calcula el perímetro de un Triangulo Equilatero
        /// </summary>
        /// <returns>Retorna el perímetro de un Triangulo Equilatero</returns>
        public virtual double GetPerimetro()
        {
            return 3 * _a;
        }        

    }
}
