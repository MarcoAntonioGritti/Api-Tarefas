using Api_Tarefas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api_Tarefas.Context
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext> options ) : base (options) 
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefa>()
                .Property(t => t.Status)
                .HasConversion<string>(); // Converte o enum para string no banco de dados
        }
    }
}
