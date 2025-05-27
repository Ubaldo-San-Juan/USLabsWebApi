using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using USLabs.Domain;

namespace USLabs.Persistence
{
    public class USLabsDbContext : DbContext
    {
        // Declaration of DbSets for each entity as properties
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Instructor> Instructores { get; set; }
        public DbSet<Precio> Precios { get; set; }
        public DbSet<Calificacion> Calificaciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=LocalDatabase.db")
            .LogTo(
                Console.WriteLine,
                new[] { DbLoggerCategory.Database.Command.Name },
                LogLevel.Information
            ).EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure entity relationships and properties here
            modelBuilder.Entity<Curso>().ToTable("cursos");
            modelBuilder.Entity<Instructor>().ToTable("instructores");
            modelBuilder.Entity<CursoInstructor>().ToTable("curso_instructores");
            modelBuilder.Entity<Precio>().ToTable("precios");
            modelBuilder.Entity<CursoPrecio>().ToTable("curso_precios");
            modelBuilder.Entity<Calificacion>().ToTable("calificaciones");
            modelBuilder.Entity<Photo>().ToTable("imagenes");

            // Configure properties for each entity
            modelBuilder.Entity<Precio>()
                .Property(b => b.PrecioActual)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Precio>()
                .Property(b => b.PrecioPromocion)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Precio>()
                .Property(b => b.Nombre)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            // Configure relationships

            //One-to-many relationships
            modelBuilder.Entity<Curso>()
                .HasMany(m => m.Fotos)
                .WithOne(m => m.Curso)
                .HasForeignKey(m => m.CursoId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Curso>()
                .HasMany(m => m.Calificaciones)
                .WithOne(m => m.Curso)
                .HasForeignKey(m => m.CursoId) // Not using isrequired here because cursoid can be null
                .OnDelete(DeleteBehavior.Restrict);

            //Many-to-many relationships
            modelBuilder.Entity<Curso>()
                .HasMany(m => m.Precios)
                .WithMany(m => m.Cursos)
                .UsingEntity<CursoPrecio>(
                    //Defining the logic of the join tables (CursoPrecio)
                    j => j
                        .HasOne(p => p.Precio)
                        .WithMany(p => p.CursoPrecios)
                        .HasForeignKey(p => p.PrecioId)
                    ,
                    j => j
                        .HasOne(p => p.Curso)
                        .WithMany(p => p.CursoPrecios)
                        .HasForeignKey(p => p.CursoId)
                    ,

                    j =>
                    {
                        j.HasKey(t => new { t.PrecioId, t.CursoId });
                    }
                );

            modelBuilder.Entity<Curso>()
                .HasMany(m => m.Instructores)
                .WithMany(m => m.Cursos)
                .UsingEntity<CursoInstructor>(
                    // Defining the logic of the join tables (CursoInstructor)
                    j => j
                        .HasOne(p => p.Instructor)
                        .WithMany(p => p.CursoInstructores)
                        .HasForeignKey(p => p.InstructorId)
                    ,
                    j => j
                        .HasOne(p => p.Curso)
                        .WithMany(p => p.CursoInstructores)
                        .HasForeignKey(p => p.CursoId)
                    ,

                    j =>
                    {
                        j.HasKey(t => new { t.InstructorId, t.CursoId });
                    }
                );


            // Logic to seed data
            modelBuilder.Entity<Curso>().HasData(DataMaster().Item1);
            modelBuilder.Entity<Precio>().HasData(DataMaster().Item2);
            modelBuilder.Entity<Instructor>().HasData(DataMaster().Item3);
        }

        public Tuple<Curso[], Precio[], Instructor[]> DataMaster()
        {
            var cursos = new List<Curso>();
            var faker = new Faker();

            for (var i = 1; i < 10; i++)
            {
                var cursoId = Guid.NewGuid();
                cursos.Add(
                    new Curso
                    {
                        Id = cursoId,
                        Titulo = faker.Commerce.ProductName(),
                        Descripcion = faker.Commerce.ProductDescription(),
                        FechaPublicacion = DateTime.UtcNow
                    }
                );
            }

            var precioId = Guid.NewGuid();
            var precio = new Precio
            {
                Id = precioId,
                Nombre = "Precio regular",
                PrecioActual = 10.0m,
                PrecioPromocion = 5.0m
            };

            var precios = new List<Precio>();
            precios.Add(precio);

            var fakerInstructor = new Faker<Instructor>()
                .RuleFor(t => t.Id, _ => Guid.NewGuid())
                .RuleFor(t => t.Nombre, f => f.Name.FirstName())
                .RuleFor(t => t.Apellidos, f => f.Name.LastName())
                .RuleFor(t => t.Grado, f => f.Name.JobTitle());

            var instructores = fakerInstructor.Generate(10);


            return Tuple.Create( cursos.ToArray(), precios.ToArray(), instructores.ToArray() );
        }
    }
}