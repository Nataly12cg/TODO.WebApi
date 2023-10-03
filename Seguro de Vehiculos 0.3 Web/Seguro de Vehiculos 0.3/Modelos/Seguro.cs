using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seguro_de_Vehiculos_0._3.Modelos
{
    public class Seguro
    {
        public decimal ValorComercial { get; set; }
        public int ReclamacionesAnteriores { get; set; }
        public decimal ValorBase { get; set; }
        public decimal Incremento { get; set; }
        public decimal TotalAntesDeIVA { get; set; }
        public decimal ValorIVA { get; set; }
        public decimal TotalAPagar { get; set; }
    }
}