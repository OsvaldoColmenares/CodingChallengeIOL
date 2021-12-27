using ChallengeIOLApi.Classes;
using ChallengeIOLApi.FakeRepository;
using ChallengeIOLApi.Repository.IRepository;
using ChallengeIOLApi.Resource;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeIOLApi.Controllers
{
    [TestFixture]
    public class FiguraControllerNUnitTest
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
        public void TestResumenListaVacia()
        {
            //1. Arrange
            //Inicializar las variables o componentes que se ejecutaran en el test         
            FiguraController controller = new FiguraController(_reportRepository);           
            //2. Act
            var result = controller.Get("es");
             ContentResult contenido = result.Result as ContentResult;
           
            //3. Assert            
            // Assert.AreEqual(400, statusCodeResult.StatusCode
             Assert.AreEqual("Lista vacía de formas!", contenido.Content);
        }

        [Test]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            //1. Arrange
            //Inicializar las variables o componentes que se ejecutaran en el test
            FiguraController controller = new FiguraController(_reportRepository);
            //2. Act
            var result = controller.Get("en");
            ContentResult contenido = result.Result as ContentResult;
            //3. Assert   
            Assert.AreEqual("Empty list of shapes!", contenido.Content);
        }


        [Test]
        public void Figura_InputIdioma_ValorIncorrecto()
        {
            //1. Arrange
            //Inicializar las variables o componentes que se ejecutaran en el test
            FiguraController controller = new FiguraController(_reportRepository);
            //2. Act
            var result = controller.Get("esxesdf");
            StatusCodeResult statusCodeResult = result.Result as StatusCodeResult;
            //Assert            
            Assert.AreEqual(400, statusCodeResult.StatusCode);
        }

    }
}
