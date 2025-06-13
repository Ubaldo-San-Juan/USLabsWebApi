using MediatR;
using USLabs.Domain;
using USLabs.Persistence;

namespace USLabs.Application.Courses.CourseCreate
{
    public class CourseCreateCommand
    {

        public record CourseCreateCommandRequest(CourseCreateRequest courseCreateRequest) : IRequest<Guid> //GUID is the type of data to return
        {

        }

        internal class CourseCreateCommandHandler: IRequestHandler<CourseCreateCommandRequest, Guid>
        {
            private readonly USLabsDbContext _context;

            public CourseCreateCommandHandler(USLabsDbContext context)
            {
                _context = context;
            }

            public async Task<Guid> Handle(CourseCreateCommandRequest request, CancellationToken cancellationToken)
            {
                var course = new Curso()
                {
                    Id = Guid.NewGuid(),
                    Titulo = request.courseCreateRequest.Title,
                    Descripcion = request.courseCreateRequest.Description,
                    FechaPublicacion = request.courseCreateRequest.PublicationDate,
                };
                _context.Add(course);
                await _context.SaveChangesAsync();
                return course.Id;
            }
        }
    }
}