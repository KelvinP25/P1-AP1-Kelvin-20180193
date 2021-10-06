using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P1_AP1_Kelvin_20180193.Entidades
{
    public class Aportes
    {
        [Key]
        public int AporteId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Persona { get; set; }
        public string Concepto { get; set; }
        public float Monto { get; set; }
    }
}
