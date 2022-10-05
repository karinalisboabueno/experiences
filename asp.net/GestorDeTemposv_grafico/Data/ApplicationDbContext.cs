using GestorDeTempos.Models;
using Microsoft.EntityFrameworkCore;

namespace GestorDeTempos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Categoria> TCategorias { get; set; }
        public DbSet<Cliente> TClientes { get; set; }
        public DbSet<Funcionario> TFuncionarios { get; set; }
        public DbSet<Tarefa> TTarefas { get; set; }
        public DbSet<Tempo> TTempos { get; set; }

        public DbSet<Utilizador>? TUtilizadores { get; set; }
    }
}
