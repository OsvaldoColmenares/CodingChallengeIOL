using ChallengeIOLApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeIOLApi.Classes
{
    /// <summary>
    /// Clase Astracta Creador: Clase creadora que declara el método de fábrica que debe devolver un objeto de Circulo, Cuadrado, etc, a través de IForma. La
    // subclase CreadorConcreto proporciona la implementación de este método.
    /// </summary>
    public abstract class Creador
    {
        public abstract IForma FactoryMethod(string nombre,int tipo, double a, double b, double c, double d);
        
    }
}
