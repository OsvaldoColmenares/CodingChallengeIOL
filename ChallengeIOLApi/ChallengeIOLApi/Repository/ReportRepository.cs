
using ChallengeIOLApi.Classes;
using ChallengeIOLApi.Interfaces;
using ChallengeIOLApi.Models;
using ChallengeIOLApi.Repository.IRepository;
using ChallengeIOLApi.Resource;
using Pluralize.NET.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeIOLApi.Repository
{
    public class ReportRepository:IReportRepository
    {
        private readonly Creador _creador;

        public ReportRepository(Creador creador)
        {
            _creador = creador;
        }

        /// <summary>
        /// Metodo AddFormas: Carga una lista generica con formas.
        /// Los datos estan hardcodeados para probar
        /// </summary>
        /// <param name="traducciones">clase para cambiar el idioma</param>
        /// <returns>Retorna una lista o colección de formas en un idioma seleccionado</returns>
        public List<IForma> AddFormas(Traduccion traducciones)
        {
            List<IForma> formas = new List<IForma>()
            {
             _creador.FactoryMethod(traducciones.Cuadrado,1, 2, 0, 0, 0),
             _creador.FactoryMethod(traducciones.Cuadrado,1, 2, 0, 0, 0),
             _creador.FactoryMethod(traducciones.TrapecioRectangulo,5, 2, 3, 4, 4),
             _creador.FactoryMethod(traducciones.Cuadrado,1, 5, 0, 0, 0),
             _creador.FactoryMethod(traducciones.Rectangulo,4, 7, 5, 0, 0),
             _creador.FactoryMethod(traducciones.TrapecioRectangulo,5, 6, 2, 1, 4),
             _creador.FactoryMethod(traducciones.TrianguloEquilatero,2, 3, 0, 0, 0),
             _creador.FactoryMethod(traducciones.Circulo,3, 6, 0, 0, 0),
             _creador.FactoryMethod(traducciones.TrapecioRectangulo,5, 9, 6, 2, 4),
             _creador.FactoryMethod(traducciones.Cuadrado,1, 5, 0, 0, 0),
             _creador.FactoryMethod(traducciones.Circulo,3, 8, 0, 0, 0),
             _creador.FactoryMethod(traducciones.TrapecioRectangulo,5, 2, 7, 8, 3),
             _creador.FactoryMethod(traducciones.Circulo,3, 7, 0, 0, 0),
             _creador.FactoryMethod(traducciones.Rectangulo,4, 6, 3, 0, 0),
             _creador.FactoryMethod(traducciones.TrapecioRectangulo,5, 5, 3, 4, 4),
             _creador.FactoryMethod(traducciones.TrianguloEquilatero,2, 6, 0, 0, 0),
            };

            return formas;
            //return null;
        }

        /// <summary>
        /// Metodo Imprimir: Calcula el área y perímetro de diferentes formas. También realiza el calculo del total de las formas con sus respectivos perímetros y áreas.
        /// Convierte en plural (Pluralizer) las formas que tienen más de 1 cantidad.
        /// </summary>
        /// <param name="formas">Lista o coleccion de formas</param>
        /// <param name="traducciones">clase para cambiar el idioma</param>
        /// <returns>Retorna un reporte del calculo de areas y perimetros de diferentes Formas en un idioma selecciondo</returns>
        public Reporte Imprimir(List<IForma> formas, Traduccion traducciones)
        {     
            Reporte reporte = new Reporte()
            {
                Nombre = traducciones.Formas,
                Cantidad = formas.Count(),
                Area = formas.Sum(a => a.GetArea()),
                Perimetro = formas.Sum(a => a.GetPerimetro()),              
                Detalles = formas
                      .GroupBy(l => l.GetNombre())
                      .Select(cl => new Detalles
                      {
                          Cantidad = cl.Count(),
                          Nombre = cl.Count() > 1 ? new Pluralizer().Pluralize(cl.First().GetNombre()) : cl.First().GetNombre(),
                          Area = cl.Sum(c => c.GetArea()),
                          Perimetro = cl.Sum(c => c.GetPerimetro())
                      }).ToList()
            };           

            return  reporte;
        }
    }
}
