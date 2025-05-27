using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USLabs.Domain
{
    public class Precio : BaseEntity
    {
        public string? Nombre { get; set; }
        public decimal PrecioActual { get; set; }
        public decimal PrecioPromocion { get; set; }

        // Navigation properties
        public ICollection<Curso>? Cursos { get; set; }
        public ICollection<CursoPrecio>? CursoPrecios { get; set; }
    }
}