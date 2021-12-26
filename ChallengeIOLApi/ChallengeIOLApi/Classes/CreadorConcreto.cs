using ChallengeIOLApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeIOLApi.Classes
{
    /// <summary>
    /// Clase CreadorConcreto: Realiza las instancias
    /// </summary>
    public class CreadorConcreto:Creador
    {
        public override IForma FactoryMethod(string nombre, int tipo, double a, double b, double c, double d)
        {                      
            switch (tipo)
            {
                case 1:
                    {
                        return new Cuadrado(nombre,a);                       
                    }
                case 2:
                    {
                        return new TrianguloEquilatero(nombre, a);                      
                    }
                case 3:
                    {
                        return new Circulo(nombre,a);                       
                    }
                case 4:
                    {
                        return new Rectangulo(nombre,a, b);                       
                    }
                case 5:
                    {
                        return new TrapecioRectangulo(nombre,a, b, c, d);                       
                    }
                
            }
            return null;
        }
    }
}
