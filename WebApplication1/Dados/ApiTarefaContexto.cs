using APITAREFA.Models;
using Microsoft.EntityFrameworkCore;

namespace APITAREFA.Dados
{
    public class ApiTarefaContexto : DbContext
    {


        public DbSet<ModelUsuario> Usuarios { get; set; }

        public DbSet<ModelPerfil> Perfils { get; set; } 

        public DbSet <ModelCategoria> Categorias { get; set; }   

        public DbSet <ModelTarefas> Tarefas { get; set; }


        public ApiTarefaContexto (DbContextOptions<ApiTarefaContexto> options) : base (options)
        {


        }


    }
}
