using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USLabs.Domain
{
    public class CursoPrecio
    {
        // Foreign keys
        public Guid CursoId { get; set; }
        public Curso? Curso { get; set; }

        public Guid PrecioId { get; set; }
        public Precio? Precio { get; set; }
    }
}