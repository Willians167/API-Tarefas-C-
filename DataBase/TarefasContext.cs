using Microsoft.EntityFrameworkCore;
using ApiTarefas.Models;
namespace ApiTarefas.DataBase;

    public class TarefasContext : DbContext
{
        #nullable disable
        public TarefasContext(DbContextOptions<TarefasContext> options) : base(options)
        {

        }
        
        public DbSet<Tarefa> Tarefas { get; set; }

         
}
