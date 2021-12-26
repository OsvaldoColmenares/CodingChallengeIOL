using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeIOLApi.Models
{
    public class Detalles
    {
        public int Cantidad { get; set; }
        public string Nombre { get; set; }             
        public double Area { get; set; }
        public double Perimetro { get; set; }      
    }

   
}
