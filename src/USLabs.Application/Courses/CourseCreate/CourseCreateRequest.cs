
using Microsoft.AspNetCore.Http;

namespace USLabs.Application.Courses.CourseCreate
{
    public class CourseCreateRequest
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? PublicationDate { get; set; }
        public IFormFile? Photo { get; set; }

        public Guid? InstructorId { get; set; }
        public Guid? PriceId { get; set; }
    }
}