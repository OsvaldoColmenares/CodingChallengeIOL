using ChallengeIOLApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeIOLApi.Classes
{
    /// <summary>
    /// Clase Cuadrado, hereda de Forma e IForma
    /// </summary>
    public class Cuadrado : Forma, IForma
    {
        protected double _a;      

        public Cuadrado(string nombre,double a): base(nombre)
        {           
            _a = a;
        }   
        /// <summary>
        /// Calcula el área de un Cuadrado
        /// </summary>
        /// <returns>Retorna el area de un Cuadrado</returns>
        public virtual double GetArea()
        {
            return Math.Pow(_a,2);
        }
        /// <summary>
        /// Calcula el perímetro de un Cuadrado
        /// </summary>
        /// <returns>Retorna el perímetro de un Cuadrado</returns>
        public virtual double GetPerimetro()
        {
            return 4 * _a;
        }
       
    }
}
