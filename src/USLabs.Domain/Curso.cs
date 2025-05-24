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

        public ICollection<Precio>? Precios { get; set; }
        public ICollection<CursoPrecio>? CursoPrecios { get; set; }

        public ICollection<Instructor>? Instructores { get; set; }
        public ICollection<CursoInstructor>? CursoInstructores { get; set; }

        public ICollection<Photo>? Fotos { get; set; }
    }
}