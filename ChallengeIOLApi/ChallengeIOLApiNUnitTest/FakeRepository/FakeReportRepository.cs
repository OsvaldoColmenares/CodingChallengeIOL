using ChallengeIOLApi.Classes;
using ChallengeIOLApi.Interfaces;
using ChallengeIOLApi.Models;
using ChallengeIOLApi.Repository.IRepository;
using ChallengeIOLApi.Resource;
using Pluralize.NET.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeIOLApi.FakeRepository
{
    public class FakeReportRepository : IReportRepository
    {
        private readonly Creador _creador;

        public FakeReportRepository(Creador creador)
        {
            _creador = creador;
        }


        public List<IForma> AddFormas(Traduccion traducciones)
        {
            return null;
        }

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

            return reporte;
        }
    }
}
