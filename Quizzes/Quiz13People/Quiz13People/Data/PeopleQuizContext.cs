using Microsoft.EntityFrameworkCore;
using Quiz13People.Models;

namespace Quiz13People.Data
{
    public class PeopleQuizContext : DbContext
    {
        public PeopleQuizContext(DbContextOptions<PeopleQuizContext> options)
            : base(options)
        {
        }

        public DbSet<People> People { get; set; }
    }
}