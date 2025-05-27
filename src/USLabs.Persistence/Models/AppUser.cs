using Microsoft.AspNetCore.Identity;

namespace USLabs.Persistence.Models
{
    public class AppUser : IdentityUser
    {
        public string? NombreCompleto { get; set; }
        public string? Carrera { get; set; }    
    }
}