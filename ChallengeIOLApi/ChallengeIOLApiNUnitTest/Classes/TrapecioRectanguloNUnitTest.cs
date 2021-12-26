using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeIOLApi.Classes
{
    [TestFixture]
    public class TrapecioRectanguloNUnitTest
    {
        [Test]
        public void GetArea_InputA_GetValorCorrecto()
        {
            //1. Arrange
            //Inicializar las variables o componentes que se ejecutaran en el test         
            TrapecioRectangulo op = new TrapecioRectangulo("Trapecio Rectangulo", 3,2,4,5);

            //2. Act
            double result = op.GetArea();

            //3. Assert            
            Assert.AreEqual(9, result);
        }

        [Test]
        public void GetPerimetro_InputA_GetValorCorrecto()
        {
            //1. Arrange
            //Inicializar las variables o componentes que se ejecutaran en el test         
            TrapecioRectangulo op = new TrapecioRectangulo("Trapecio Rectangulo", 3, 2, 4, 5);

            //2. Act
            double result = op.GetPerimetro();

            //3. Assert            
            Assert.AreEqual(14, result);

        }
    }
}
