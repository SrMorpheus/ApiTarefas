namespace APITAREFA.Models
{
    public class ModelTarefas
    {

        public int Id { get; set; }

        public string Titulo { get; set; }

        public DateTime DataHora { get; set; }  

        public string Descricao { get; set; }

        public int ModelCategoriaId { get; set; }   

        public int ModelUsuarioId { get; set; } 

        public ModelCategoria Categoria { get; set; }

        public ModelUsuario Usuarii { get; set; }





    }
}
