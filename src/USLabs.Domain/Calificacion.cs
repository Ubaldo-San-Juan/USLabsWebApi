using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USLabs.Domain
{
    public class Calificacion : BaseEntity
    {
        public string? Alumno { get; set; }
        public int Puntaje { get; set; }
        public string? Comentario { get; set; }
    }
}