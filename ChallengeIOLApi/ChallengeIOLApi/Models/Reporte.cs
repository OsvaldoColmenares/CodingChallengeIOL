using ChallengeIOLApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeIOLApi.Models
{
    public class Reporte
    {
       
        public int Cantidad { get; set; }
        public string Nombre { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }      
        public List<Detalles> Detalles { get; set; }
       
    }
}
