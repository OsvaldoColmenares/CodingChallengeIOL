using ChallengeIOLApi.Classes;
using ChallengeIOLApi.FakeRepository;
using ChallengeIOLApi.Interfaces;
using ChallengeIOLApi.Models;
using ChallengeIOLApi.Repository.IRepository;
using ChallengeIOLApi.Resource;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChallengeIOLApi.Repository
{
    [TestFixture]
    public class ReportRepositoryNUnitTest
    {
        private Creador _creador;
        private IReportRepository _reportRepository;

        [SetUp]

        public void Setup()
        {
            _creador = new CreadorConcreto();
            _reportRepository = new FakeReportRepository(_creador);
        }


        [Test]
        public void TestResumenListaConUnCuadrado()
        {
            //1. Arrange
            //Inicializar las variables o componentes que se ejecutaran en el test
            var traducciones = new Traduccion(CultureInfo.GetCultureInfo("es"));
            List<IForma> formas = new List<IForma>()
            {
             _creador.FactoryMethod(traducciones.Cuadrado, 1, 2, 0, 0, 0),
            };

            //2. Act
            Reporte result = _reportRepository.Imprimir(formas,traducciones);
            string json = JsonSerializer.Serialize(result);

            //3. Assert
            Assert.AreEqual("{\"Cantidad\":1,\"Nombre\":\"Formas\",\"Area\":4,\"Perimetro\":8,\"Detalles\":[{\"Cantidad\":1,\"Nombre\":\"Cuadrado\",\"Area\":4,\"Perimetro\":8}]}", json);
        }


        [Test]
        public void TestResumenListaConMasCuadrados()
        {
            //1. Arrange
            var traducciones = new Traduccion(CultureInfo.GetCultureInfo("en"));
            List<IForma> formas = new List<IForma>()
            {
             _creador.FactoryMethod(traducciones.Cuadrado, 1, 5, 0, 0, 0),
             _creador.FactoryMethod(traducciones.Cuadrado,1, 1, 0, 0, 0),
             _creador.FactoryMethod(traducciones.Cuadrado,1, 3, 0, 0, 0)
            };

            //2. Act
            Reporte result = _reportRepository.Imprimir(formas,traducciones);
            string json = JsonSerializer.Serialize(result);

            //3. Assert
            Assert.AreEqual("{\"Cantidad\":3,\"Nombre\":\"Shapes\",\"Area\":35,\"Perimetro\":36,\"Detalles\":[{\"Cantidad\":3,\"Nombre\":\"Squares\",\"Area\":35,\"Perimetro\":36}]}", json);
        }


        [Test]
        public void TestResumenListaConMasTipos()
        {
            //1. Arrange //cambiar iidioma aqui
            var traducciones = new Traduccion(CultureInfo.GetCultureInfo("en"));
            List<IForma> formas = new List<IForma>()
            {
             _creador.FactoryMethod(traducciones.Cuadrado,1, 5, 0, 0, 0),
             _creador.FactoryMethod(traducciones.Circulo,3, 3, 0, 0, 0),
             _creador.FactoryMethod(traducciones.TrianguloEquilatero,2, 4, 0, 0, 0),
             _creador.FactoryMethod(traducciones.Cuadrado,1, 2, 0, 0, 0),
             _creador.FactoryMethod(traducciones.TrianguloEquilatero,2, 9, 0, 0, 0),
             _creador.FactoryMethod(traducciones.Circulo,3, 2.75, 0, 0, 0),
             _creador.FactoryMethod(traducciones.TrianguloEquilatero,2, 4.2, 0, 0, 0)
            };

            //2. Act
            Reporte result = _reportRepository.Imprimir(formas,traducciones);
            string json = JsonSerializer.Serialize(result);

            //3. Assert
            Assert.AreEqual("{\"Cantidad\":7,\"Nombre\":\"Shapes\",\"Area\":130.67320447000498,\"Perimetro\":115.7283155162826,\"Detalles\":[{\"Cantidad\":2,\"Nombre\":\"Squares\",\"Area\":29,\"Perimetro\":28},{\"Cantidad\":2,\"Nombre\":\"Circles\",\"Area\":52.03262832508095,\"Perimetro\":36.12831551628262},{\"Cantidad\":3,\"Nombre\":\"Equilateral triangles\",\"Area\":49.64057614492402,\"Perimetro\":51.6}]}", json);
        }


        [Test]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            //1. Arrange          
            var traducciones = new Traduccion(CultureInfo.GetCultureInfo("es"));
            List<IForma> formas = new List<IForma>()
            {
             _creador.FactoryMethod(traducciones.Cuadrado,1, 5, 0, 0, 0),
             _creador.FactoryMethod(traducciones.Circulo,3, 3, 0, 0, 0),
             _creador.FactoryMethod(traducciones.TrianguloEquilatero,2, 4, 0, 0, 0),
             _creador.FactoryMethod(traducciones.Cuadrado,1, 2, 0, 0, 0),
             _creador.FactoryMethod(traducciones.TrianguloEquilatero,2, 9, 0, 0, 0),
             _creador.FactoryMethod(traducciones.Circulo,3, 2.75, 0, 0, 0),
             _creador.FactoryMethod(traducciones.TrianguloEquilatero,2, 4.2, 0, 0, 0)
            };

            //2. Act
            Reporte result = _reportRepository.Imprimir(formas, traducciones);
            string json = JsonSerializer.Serialize(result);

            //3. Assert
            Assert.AreEqual("{\"Cantidad\":7,\"Nombre\":\"Formas\",\"Area\":130.67320447000498,\"Perimetro\":115.7283155162826,\"Detalles\":[{\"Cantidad\":2,\"Nombre\":\"Cuadrados\",\"Area\":29,\"Perimetro\":28},{\"Cantidad\":2,\"Nombre\":\"Circulos\",\"Area\":52.03262832508095,\"Perimetro\":36.12831551628262},{\"Cantidad\":3,\"Nombre\":\"Triangulo Equilateros\",\"Area\":49.64057614492402,\"Perimetro\":51.6}]}", json);
        }

        


    }
}
