using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USLabs.Domain
{
    public class Curso : BaseEntity
    {
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }

        // Navigation properties
        public ICollection<Calificacion>? Calificaciones { get; set; }
    }
}