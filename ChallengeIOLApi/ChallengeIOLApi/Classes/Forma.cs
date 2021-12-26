using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeIOLApi.Classes
{
   
    /// <summary>
    /// Clase Abstracta Forma
    /// </summary>
    public abstract class Forma
    {
        protected string _nombre;

        public Forma(string nombre)
        {
            _nombre = nombre;
        }

        /// <summary>
        /// Metodo de la Clase Forma
        /// </summary>
        /// <returns>Retorna el nombre de la Forma</returns>

        public virtual string GetNombre()
        {
            return _nombre;
        }
    }
}
