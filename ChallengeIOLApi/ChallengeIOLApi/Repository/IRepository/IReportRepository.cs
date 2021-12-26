using ChallengeIOLApi.Interfaces;
using ChallengeIOLApi.Models;
using ChallengeIOLApi.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeIOLApi.Repository.IRepository
{
    public interface IReportRepository
    {
        List<IForma> AddFormas(Traduccion traducciones);
        Reporte Imprimir(List<IForma> formas, Traduccion traducciones);
    }
}
