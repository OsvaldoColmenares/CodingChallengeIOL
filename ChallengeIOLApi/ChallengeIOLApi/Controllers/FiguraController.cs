using ChallengeIOLApi.Models;
using ChallengeIOLApi.Repository.IRepository;
using ChallengeIOLApi.Resource;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeIOLApi.Controllers
{
    /// <summary>
    /// Controlador Figura
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class FiguraController : ControllerBase
    {
        private readonly IReportRepository _reportRepository;

        public FiguraController(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }

        /// <summary>
        /// Metodo Get: Genera un reporte con diferentes formas geometricas
        /// </summary>
        /// <param name="idioma">Los idiomas disponibles son es, en y fr</param>
        /// <returns>Retorna un reporte en json de las Figuras o Formas en el idioma seleccionado</returns>
        [HttpGet ("{idioma}")]
        public ActionResult<Reporte> Get(string idioma = "es")
        {
            if (idioma == "es" || idioma == "en" || idioma == "fr")
            {               
                var traducciones = new Traduccion(CultureInfo.GetCultureInfo(idioma));
                var lista = _reportRepository.AddFormas(traducciones);
                if (lista == null)
                {
                    return Content(traducciones.Listavaciadeformas);
                }
                return _reportRepository.Imprimir(lista, traducciones);
            }
            else
            {
                return StatusCode(400);
            }
            
        }

    }



}
