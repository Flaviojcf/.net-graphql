using graphqlAPI.Context.ContextConfiguration;
using graphqlAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace graphqlAPI.Context
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var ids = new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

            builder.ApplyConfiguration(new SuperHeroiContextConfiguration(ids));
            builder.ApplyConfiguration(new SuperPoderContextConfiguration(ids));
            builder.ApplyConfiguration(new FilmeContextConfiguration(ids));
        }

        // Adiciona os DbSets para cada modelo
        public DbSet<SuperHeroi> SuperHerois { get; set; }
        public DbSet<SuperPoder> SuperPoderes { get; set; }
        public DbSet<Filme> Filmes { get; set; }
    }
}
