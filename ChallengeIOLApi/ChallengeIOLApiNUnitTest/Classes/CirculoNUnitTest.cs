using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeIOLApi.Classes
{
    [TestFixture]
    public class CirculoNUnitTest
    {
        [Test]
        public void GetArea_InputA_GetValorCorrecto()
        {
            //1. Arrange
            //Inicializar las variables o componentes que se ejecutaran en el test         
            Circulo op = new Circulo("Circulo",3);

            //2. Act
            double result = op.GetArea();

            //3. Assert            
            Assert.AreEqual(28.274333882308138, result);
            
        }

        [Test]
        public void GetPerimetro_InputA_GetValorCorrecto()
        {
            //1. Arrange
            //Inicializar las variables o componentes que se ejecutaran en el test         
            Circulo op = new Circulo("Circulo",3 );

            //2. Act
            double result = op.GetPerimetro();

            //3. Assert            
            Assert.AreEqual(18.849555921538759, result);

        }
    }
}
