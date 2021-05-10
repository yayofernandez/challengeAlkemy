using Microsoft.EntityFrameworkCore;

namespace Subjects.Models 
{
      public class SubjectsContext : DbContext 
      {
          public SubjectsContext(DbContextOptions<SubjectsContext> opciones)
          : base(opciones)
          {

          }

          public DbSet<SubjectsContext> Subjects {  get; set; }
      }

}