using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USLabs.Domain
{
    public class Photo : BaseEntity
    {
        public string? Url { get; set; }

        // Foreign Key
        public Guid CursoId { get; set; }
        public Curso? Curso { get; set; }
    }
}