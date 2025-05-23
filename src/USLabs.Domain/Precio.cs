using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USLabs.Domain
{
    public class Precio
    {
        public string? Nombre { get; set; }
        public decimal PrecioActual { get; set; }
        public decimal PrecioPromocion { get; set; }
    }
}